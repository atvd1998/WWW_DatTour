using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TourCore.Models.Db;

namespace TourCore.Services
{
    public class SiteService
    {
        public  string GetTitle() {
            return "Grand Tour Travel Category Flat Bootstrap Responsive Web Template | Home :: w3layouts";
        }

        public  Account GetUserInfo()
        {
            Account acData = null;
           
            return acData;
        }
    }
}
