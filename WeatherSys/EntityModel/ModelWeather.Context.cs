﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherSys.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class weatherEntities : DbContext
    {
        public weatherEntities()
            : base("name=weatherEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DayTemperatures> DayTemperatures { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Profiles_Settings> Profiles_Settings { get; set; }
        public DbSet<Sources> Sources { get; set; }
        public DbSet<User_Locations> User_Locations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Weather_Days> Weather_Days { get; set; }
        public DbSet<Weather_Descriptions> Weather_Descriptions { get; set; }
        public DbSet<Weather_Hours> Weather_Hours { get; set; }
    }
}
