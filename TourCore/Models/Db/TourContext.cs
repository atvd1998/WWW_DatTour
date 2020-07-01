using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TourCore.Models.ViewModels;

namespace TourCore.Models.Db
{
    public class TourContext: DbContext
    {
        public TourContext(DbContextOptions options):base(options)
        { }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractDetail> ContractDetails { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Member> Members { get; set; }



    }
}
