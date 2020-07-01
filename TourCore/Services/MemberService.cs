using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;


namespace TourCore.Services
{
    public class MemberService
    {
        private readonly TourContext _db;
        public MemberService(TourContext tourContext)
        {
            this._db = tourContext;
        }
        public void SaveInfoMember(MemberViewModel viewModel)
        {
            var saveInfoMember = new Member();
            {
                saveInfoMember.Username = viewModel.Username;
                saveInfoMember.Password = viewModel.Password;
                saveInfoMember.Email = viewModel.Email;
                saveInfoMember.Role = "mem";
            }
            this._db.Members.Add(saveInfoMember);
            this._db.SaveChanges();
        }
        public bool LoginMember(string Username,string Password)
        {
            var check = _db.Members.ToList();
            var result = check.Count(n => n.Username == Username && n.Password == Password && n.Role == "mem");
            if (result >0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
