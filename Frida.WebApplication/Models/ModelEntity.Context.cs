﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Frida.WebApplication.Models
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
    
        public virtual DbSet<abonoagente> abonoagentes { get; set; }
        public virtual DbSet<acabadomp> acabadomps { get; set; }
        public virtual DbSet<agentesventa> agentesventas { get; set; }
        public virtual DbSet<almacen_modelo> almacen_modelo { get; set; }
        public virtual DbSet<anclaagente> anclaagentes { get; set; }
        public virtual DbSet<asignacion_av_pvf> asignacion_av_pvf { get; set; }
        public virtual DbSet<catalogomp> catalogomps { get; set; }
        public virtual DbSet<catformapago> catformapagoes { get; set; }
        public virtual DbSet<catmetodopago> catmetodopagoes { get; set; }
        public virtual DbSet<catusocfdi> catusocfdis { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<cliente1> clientes1 { get; set; }
        public virtual DbSet<con_almacenes> con_almacenes { get; set; }
        public virtual DbSet<con_osmpa> con_osmpa { get; set; }
        public virtual DbSet<con_osmph> con_osmph { get; set; }
        public virtual DbSet<con_pedidospvf> con_pedidospvf { get; set; }
        public virtual DbSet<conabonos_clientes> conabonos_clientes { get; set; }
        public virtual DbSet<conabonos_clientes1> conabonos_clientes1 { get; set; }
        public virtual DbSet<conentrada_almacen> conentrada_almacen { get; set; }
        public virtual DbSet<conentrada> conentradas { get; set; }
        public virtual DbSet<confactura_electronica> confactura_electronica { get; set; }
        public virtual DbSet<conlote> conlotes { get; set; }
        public virtual DbSet<connotacredito> connotacreditoes { get; set; }
        public virtual DbSet<conorden_compra> conorden_compra { get; set; }
        public virtual DbSet<conorden_salida> conorden_salida { get; set; }
        public virtual DbSet<conos_conpvf> conos_conpvf { get; set; }
        public virtual DbSet<conpedido> conpedidos { get; set; }
        public virtual DbSet<conrecibo> conrecibos { get; set; }
        public virtual DbSet<conrecibos1> conrecibos1 { get; set; }
        public virtual DbSet<conventa> conventas { get; set; }
        public virtual DbSet<corridas_produccion> corridas_produccion { get; set; }
        public virtual DbSet<cuentasdep> cuentasdeps { get; set; }
        public virtual DbSet<dellatedeposito> dellatedepositos { get; set; }
        public virtual DbSet<dellatedepositos1> dellatedepositos1 { get; set; }
        public virtual DbSet<departamentosmp> departamentosmps { get; set; }
        public virtual DbSet<detallecheque> detallecheques { get; set; }
        public virtual DbSet<detallecheque1> detallecheque1 { get; set; }
        public virtual DbSet<detalledescuento> detalledescuentoes { get; set; }
        public virtual DbSet<detalledescuento1> detalledescuento1 { get; set; }
        public virtual DbSet<dphabilitacion> dphabilitacions { get; set; }
        public virtual DbSet<ejemploruta> ejemplorutas { get; set; }
        public virtual DbSet<email_settings> email_settings { get; set; }
        public virtual DbSet<email> emails { get; set; }
        public virtual DbSet<empresa> empresas { get; set; }
        public virtual DbSet<familiamp> familiamps { get; set; }
        public virtual DbSet<foto> fotos { get; set; }
        public virtual DbSet<kardexam> kardexams { get; set; }
        public virtual DbSet<kardexmp> kardexmps { get; set; }
        public virtual DbSet<kardexo> kardexos { get; set; }
        public virtual DbSet<kardexpvf> kardexpvfs { get; set; }
        public virtual DbSet<lavanderia> lavanderias { get; set; }
        public virtual DbSet<lote> lotes { get; set; }
        public virtual DbSet<maquilero> maquileroes { get; set; }
        public virtual DbSet<mp> mps { get; set; }
        public virtual DbSet<nodos_ruta> nodos_ruta { get; set; }
        public virtual DbSet<producto> productoes { get; set; }
        public virtual DbSet<proveedoresmp> proveedoresmps { get; set; }
        public virtual DbSet<subfamiliamp> subfamiliamps { get; set; }
        public virtual DbSet<sucursal> sucursals { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<almacen_av_pvf> almacen_av_pvf { get; set; }
        public virtual DbSet<almacene> almacenes { get; set; }
        public virtual DbSet<catclaveprodserv> catclaveprodservs { get; set; }
        public virtual DbSet<catclaveunidad> catclaveunidads { get; set; }
        public virtual DbSet<claves_estados> claves_estados { get; set; }
        public virtual DbSet<clavesat_productos> clavesat_productos { get; set; }
        public virtual DbSet<ejemploagente> ejemploagentes { get; set; }
        public virtual DbSet<entrada_almacen> entrada_almacen { get; set; }
        public virtual DbSet<entrada> entradas { get; set; }
        public virtual DbSet<factura_electronica> factura_electronica { get; set; }
        public virtual DbSet<fe> fes { get; set; }
        public virtual DbSet<folio> folios { get; set; }
        public virtual DbSet<foliosfe> foliosfes { get; set; }
        public virtual DbSet<notacredito> notacreditoes { get; set; }
        public virtual DbSet<orden_compra> orden_compra { get; set; }
        public virtual DbSet<orden_salida> orden_salida { get; set; }
        public virtual DbSet<osmpa> osmpas { get; set; }
        public virtual DbSet<osmph> osmphs { get; set; }
        public virtual DbSet<pedido> pedidos { get; set; }
        public virtual DbSet<pedidos_pvf> pedidos_pvf { get; set; }
        public virtual DbSet<recibosch> recibosches { get; set; }
        public virtual DbSet<recibosdep> recibosdeps { get; set; }
        public virtual DbSet<recibosed> reciboseds { get; set; }
        public virtual DbSet<regimen_fiscal> regimen_fiscal { get; set; }
        public virtual DbSet<venta> ventas { get; set; }
        public virtual DbSet<visitante> visitantes { get; set; }
    }
}
