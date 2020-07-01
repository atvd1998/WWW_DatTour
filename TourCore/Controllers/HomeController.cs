using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;
using TourCore.Services;

namespace TourCore.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly TourContext _db;
        private readonly MemberService _memberService;
        public HomeController(TourContext db, MemberService memberService)
        {
            this._db = db;
            this._memberService = memberService;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if (this._memberService.LoginMember(Username, Password) == true)
            {
                HttpContext.Session.SetString("Username",Username);
                return RedirectToAction("Index", "Home");
            }
            string error = "Tài khoản hoặc mật khẩu không đúng!!!";
            ViewBag.Error = error;
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(MemberViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _memberService.SaveInfoMember(viewModel);
                return RedirectToAction("Login");
            }

            string error = "Đăng kí không thành công";
            ViewBag.Error = error;
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Index");
        }
    }
}
