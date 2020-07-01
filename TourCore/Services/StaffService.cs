using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Commands;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class StaffService
    {
        private readonly TourContext _db;
        public StaffService(TourContext db)
        {
            this._db = db;
        }
        public void AddStaff(StaffCommand staffCommand)
        {
            var newStaff = new Staff();
            {
                newStaff.Name = staffCommand.Name;
                newStaff.Phone = staffCommand.Phone;
                newStaff.DOB = staffCommand.DOB;
                newStaff.Address = staffCommand.Address;
                newStaff.Gender = staffCommand.Gender;
            }
            _db.Staffs.Add(newStaff);
            _db.SaveChanges();
        }
        public List<StaffViewModel> AllStaff()
        {
            var listStaff = new List<StaffViewModel>();
           
            using (var connection = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();
                listStaff = connection.Query<StaffViewModel>(@"Select * From Staff").ToList();
                connection.Close();
            }
            return listStaff;
        }
    }
}
