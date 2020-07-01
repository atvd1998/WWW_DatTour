using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.Db;
using TourCore.Models.ViewModels;

namespace TourCore.Services
{
    public class TourService
    {
        private readonly TourContext _db;
        public TourService(TourContext db)
        {
            this._db = db;
        }
        public List<TourViewModel> Domestic()
        {
            var domestics = new List<TourViewModel>();
          
            // --Use Dapper--
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                domestics = conn.Query<TourViewModel>(@"select * from Tour where Dos=1").ToList();
                conn.Close();
            }
            return domestics;
        }
        public List<TourViewModel> National()
        {
            var nationals = new List<TourViewModel>();
            using (var connection = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();
                nationals = connection.Query<TourViewModel>(@"select * from Tour where Na=1").ToList();
                connection.Close();
            }
            return nationals;
        }
       
        public TourViewModel TourDetail(int? id)
        {
            var tourId = new List<TourViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourId = conn.Query<TourViewModel>("select * from Tour where Id=" + id).ToList();
                conn.Close();
            }
            return tourId.SingleOrDefault(n => n.Id == id);
        }
        public List<TourViewModel> FindTour(string nameTour/*,DateTime beginDate*/)
        {
            var findTour = new List<TourViewModel>();
            using (var connection = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();
                if(nameTour != null)
                {
                    findTour = connection.Query<TourViewModel>(@"select * from Tour").Where(n => n.NameTour.Contains(nameTour)).ToList();
                }
                connection.Close();
            }
            return findTour;
        }
    }

}
