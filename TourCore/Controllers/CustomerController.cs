using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly TourContext _db;
        public CustomerController(TourContext db)
        {
            this._db = db;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string Username,string Password)
        //{
        //    Account ac = _db.Accounts.SingleOrDefault(n => n.Username == Username && n.Password == Password);
          
        //    if (ac != null)
        //    {
        //        var session = HttpContext.Session;
        //        var sessionValue= JsonSerializer.Serialize(ac); // convert object to string
        //        session.SetString("Account", sessionValue); // Session["Account"] = sessionValue;


        //        var data = session.GetString("Account"); // "1"  data = Session["Account"];
        //        var acData = JsonSerializer.Deserialize<Account>(data);

        //        return RedirectToAction("Index","Home");
        //    }
        //    string content = "Login failed";
        //    ViewBag.content = content;
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Register(Account account)
        //{
        //    _db.Accounts.Add(account);
        //    _db.SaveChanges();
        //    return View("/Views/Customer/Login.cshtml");
        //}
    }
}