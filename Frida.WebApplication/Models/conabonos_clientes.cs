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
    
    public partial class conabonos_clientes
    {
        public int index { get; set; }
        public string FolioOS { get; set; }
        public System.DateTime Fecha { get; set; }
        public double total { get; set; }
        public int NoEfectivoOper { get; set; }
        public int NoChequeOper { get; set; }
        public int NoChequeDocOper { get; set; }
        public int NoDepositoOper { get; set; }
        public int NoNotaCreditoOper { get; set; }
        public double Efectivo { get; set; }
        public double Cheque { get; set; }
        public double Cheque_Documentado { get; set; }
        public double Deposito { get; set; }
        public double NotaCredito { get; set; }
        public bool eliminar { get; set; }
        public double saldo { get; set; }
        public string FolioNC { get; set; }
        public string Cliente { get; set; }
        public int NoDescuentoOper { get; set; }
        public double Descuento { get; set; }
    }
}
