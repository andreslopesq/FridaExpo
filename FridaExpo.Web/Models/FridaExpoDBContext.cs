﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FridaExpo.Web.Models
{
    public class FridaExpoDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FridaExpoDBContext() : base("name=FridaExpoDBContext")//"Server=MYSQL5011.site4now.net;Database=db_9b318c_frida;Uid=9b318c_frida;Pwd=vpnstore2004"
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<visitante>()
           .ToTable("visitante");
        }

        public System.Data.Entity.DbSet<FridaExpo.Web.Models.visitante> visitantes { get; set; }
    }
}
