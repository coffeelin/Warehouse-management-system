using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Configuration;

namespace WMSDAO.Models
{
    public class WMSContext : DbContext
    {
        public WMSContext()
			: base(ConfigurationManager.ConnectionStrings["WMSConnString"].ConnectionString) {
            Database.SetInitializer<WMSContext>(null);
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Dine> Dines { get; set; }
        public DbSet<DineDeatil> DineDetails { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }


    }
}
