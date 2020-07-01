using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;
using TourCore.Services;

namespace TourCore.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly TourContext _db;
        public TourController(TourService tourService,TourContext db)
        {
            this._db = db;
            this._tourService = tourService;
        }
        public IActionResult Domestic()
        {
            var model = this._tourService.Domestic();
            return View(model);
        }
        public IActionResult National()
        {
            var model = this._tourService.National();
            return View(model);
        }
        public IActionResult TourDetail(int? id)
        {
            if(id==null)
            {
                return View("/Views/Shared/Error.cshtml");
            }
            var model = _tourService.TourDetail(id);
            if(model==null)
            {
                return null;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult FindTour(string nameTour/*,DateTime beginDate*/)
        {
            var model= this._tourService.FindTour(nameTour);
            return View(model);
        }
    }
}