﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FridaExpo.Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class configuracionEntities : DbContext
    {
        public configuracionEntities()
            : base("name=configuracionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<con_pedidospvf> con_pedidospvf { get; set; }
        public virtual DbSet<conorden_salida> conorden_salida { get; set; }
        public virtual DbSet<conpedido> conpedidos { get; set; }
        public virtual DbSet<producto> productoes { get; set; }
        public virtual DbSet<visitante> visitantes { get; set; }
        public virtual DbSet<orden_salida> orden_salida { get; set; }
        public virtual DbSet<pedido> pedidos { get; set; }
        public virtual DbSet<pedidos_pvf> pedidos_pvf { get; set; }
    }
}
