using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using TourCore.Models.Commands;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class BookingService
    {
        private readonly TourContext _db;
        private readonly TourService _tourService;
        private readonly DbSet<Tour> dbSet;

        public BookingService(TourContext db, TourService tourService)
        {
            this._db = db;
            this._tourService = tourService;
            dbSet = _db.Set<Tour>();
        }

        public void BookingTour(BookingTourCommand command)
        {
            var newCustomer = new Customer();

            newCustomer.Name = command.Name;
            newCustomer.Email = command.Email;
            newCustomer.Address = command.Address;
            newCustomer.Phone = command.Phone;

            _db.Customers.Add(newCustomer);
            _db.SaveChanges();
            //Insert Contract
            ContractViewModel contract = new ContractViewModel();
            {
                contract.CustomerId = newCustomer.Id;
                contract.TourId = command.TourId;
                contract.BeginDate = command.BeginDate;
                contract.Paid = false;
                contract.Content = command.Content;
            }
            var newContract = new Contract(contract);
            _db.Contracts.Add(newContract);
            _db.SaveChanges();

            var tour = new Tour();
            using (var connection = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();
                if (command != null)
                {
                    tour = connection.Query<Tour>(@"select * from Tour").FirstOrDefault(n => n.Id == command.TourId);
                }
                connection.Close();
            }

            tour.Quantity = tour.Quantity - Convert.ToInt32(command.PeopleGo);

            dbSet.Attach(tour);
            _db.Entry(tour).State = EntityState.Modified;

            _db.SaveChanges();
            //Insert ContractDetail
            ContractDetailViewModel contractDetail = new ContractDetailViewModel();
            {
                contractDetail.TourId = tour.Id;
                contractDetail.NameTour = tour.NameTour;
                contractDetail.Cost = tour.Cost;
                contractDetail.PeopleGo = Convert.ToInt32(command.PeopleGo);
                contractDetail.ContractId = newContract.Id;
            }
            var newContractDetail = new ContractDetail();
            {
                newContractDetail.TourId = contractDetail.TourId;
                newContractDetail.NameTour = contractDetail.NameTour;
                newContractDetail.Cost = contractDetail.Cost;
                newContractDetail.PeopleGo = contractDetail.PeopleGo;
                newContractDetail.ContractId = contractDetail.ContractId;
            }
            _db.ContractDetails.Add(newContractDetail);
            _db.SaveChanges();

            using (MailMessage emailMessage = new MailMessage())
            {
                emailMessage.From = new MailAddress("thanhtung4498@gmail.com", "Công ty du lịch");
                emailMessage.To.Add(new MailAddress("iuhthanhtung4498@gmail.com", "Account1"));
                emailMessage.Subject = "Thông tin đặt tour";
                emailMessage.Body = "TourId: " + contractDetail.TourId + Environment.NewLine + "Tên Tour: " + contractDetail.NameTour + Environment.NewLine + "Giá: " + contractDetail.Cost + Environment.NewLine + "Số người đi: " + contractDetail.PeopleGo;
                emailMessage.Priority = MailPriority.Normal;
                using (SmtpClient MailClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    MailClient.EnableSsl = true;
                    MailClient.Credentials = new System.Net.NetworkCredential("thanhtung4498@gmail.com", "tungvipro809");
                    MailClient.Send(emailMessage);
                }
            }
        }

        public void SendMail(Email email)
        {
            string to = email.To;
            string subject = email.Subject;
            string body = email.Body;
            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.From = new MailAddress("thanhtung4498@gmail.com");

            mail.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient();
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("account2@gmail.com", "password");
            smtp.Send(mail);
        }
    }
}