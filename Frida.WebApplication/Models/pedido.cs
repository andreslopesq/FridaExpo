//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class pedido
    {
        public string folio { get; set; }
        public System.DateTime fecha { get; set; }
        public string Descripcion { get; set; }
        public int cantidad { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }
        public string cliente { get; set; }
        public int nopzas { get; set; }
        public string modelo { get; set; }
        public string codigob { get; set; }
        public bool eliminar { get; set; }
        public string estado { get; set; }
        public int surtidas { get; set; }
        public int pzasxpaq { get; set; }
    }
}
