using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourCore.Models.Commands;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;
using TourCore.Services;
using X.PagedList;
namespace TourCore.Controllers
{
    public class AdminController : Controller
    {
        private readonly QuantitySevice _quantitySevice;
        private readonly TravelService _travelService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly StaffService _staffService;
        private readonly TourContext _db;
        public AdminController(QuantitySevice quantitySevice, TravelService travelService,
                              IHostingEnvironment hostingEnvironment, TourContext db,
                              StaffService staffService)
        {
            this._staffService = staffService;
            this._hostingEnvironment = hostingEnvironment;
            this._quantitySevice = quantitySevice;
            this._travelService = travelService;
            this._db = db;
        }
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("Admin")==null)
            {
                return RedirectToAction("Login","Admin");
            }
            else
            {
                HttpContext.Session.Remove("Admin");
                return View();
            }
        }
        public IActionResult QuantityMember()
        {
            var model = this._quantitySevice.QuantityMember();
            return View(model);
        }
        public IActionResult Travel()
        {
            var model = this._travelService.ListTravel();
            ViewBag.Info = string.Empty;
            return View(model);
        }
        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStaff(StaffCommand staffCommand)
        {
            if(ModelState.IsValid)
            {
                this._staffService.AddStaff(staffCommand);
                return RedirectToAction("AllStaff","Admin");
            }
            return View();
        }
        public IActionResult AllStaff()
        {
            var model = this._staffService.AllStaff();
            return View(model);
        }
        [HttpGet]
        public IActionResult InsertTour()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertTour(InsertTourCommand tourCommand)
        {
            string getNamePicture = null;
            if(tourCommand!=null)
            {
                getNamePicture = Path.GetFileName(tourCommand.Picture.FileName);
                var uploadFolder = Path.Combine(this._hostingEnvironment.WebRootPath,"images/tour_images");
                var getPictureToFolder = Path.Combine(uploadFolder,getNamePicture);
                if (System.IO.File.Exists(getPictureToFolder))
                {
                    ViewBag.Picture = "Hình ảnh đã tồn tại";
                    return View();
                }
                else
                {
                    var filestream = new FileStream(getPictureToFolder, FileMode.Create);
                    tourCommand.Picture.CopyTo(filestream);
                    var newTour = new Tour();
                    {
                        newTour.NameTour = tourCommand.NameTour;
                        newTour.Code = tourCommand.Code;
                        newTour.Day = tourCommand.Day;
                        newTour.Night = tourCommand.Night;
                        if (tourCommand.CheckNational == true)
                        {
                            newTour.Dos = true;
                            newTour.Na = false;
                        }
                        else
                        {
                            newTour.Dos = false;
                            newTour.Na = true;
                        }
                        newTour.Description = tourCommand.Description;
                        newTour.Cost = tourCommand.Cost;
               
                        newTour.Quantity = tourCommand.Quantity;
                        newTour.Picture = getNamePicture;
                        newTour.Title = tourCommand.Title;
                    }
                    _db.Tours.Add(newTour);
                    _db.SaveChanges();
                    RedirectToAction("Index","Admin");
                }
            }
            return View("ShowAllTour");
        }
        public IActionResult ShowAllTour(int? page)
        {
            if (page == null) page=1;
            var allTour = this._travelService.ShowAllTour();
            allTour.OrderByDescending(x=>x.Id);
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(allTour.ToPagedList(pageNumber,pageSize));
        }
        [HttpGet]
        public IActionResult EditTour(int id)
        {
            var model = this._travelService.SeeTour(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditTour(InsertTourCommand command)
        {
            this._travelService.EditTour(command);
            return RedirectToAction("ShowAllTour", "Admin");
        }
        public IActionResult DeleteTour(InsertTourCommand command)
        {
            this._travelService.DeleteTour(command);
            return RedirectToAction("ShowAllTour","Admin");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            string strUsername = form["username"].ToString();
            string strPassword = form["password"].ToString();
            var check = _db.Members.Count(n=>n.Username==strUsername && n.Password==strPassword && n.Role == "ad");
            if(check > 0)
            {
                HttpContext.Session.SetString("Admin",strUsername);
                return RedirectToAction("Index","Admin");
            }
            ViewBag.Error= "Đăng nhập không thành công";
            return View();
        }
        public IActionResult SeeContractDetail(int? id)
        {
            var model = this._travelService.SeeContractDeTail(id);
            return View(model);
        }
        public IActionResult DeleteContractDetail(int? id)
        {
            this._travelService.DeleteContractDetail(id);
            return RedirectToAction("Travel","Admin");
        }
    }
}