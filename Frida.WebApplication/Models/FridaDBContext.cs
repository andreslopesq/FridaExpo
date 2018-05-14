using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Frida.WebApplication.Models
{
    public class FridaDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FridaDBContext() : base("name=FridaDBContext")
        {
        }

        public System.Data.Entity.DbSet<Frida.WebApplication.Models.cliente> clientes { get; set; }

        public System.Data.Entity.DbSet<Frida.WebApplication.Models.visitante> visitantes { get; set; }
    }
}
