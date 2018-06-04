namespace FridaExpo.Web.Helpers
{
    using FridaExpo.Web.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Funciones
    {
        private FridaExpoDBContext db = new FridaExpoDBContext();

        public int GetFolio(String tipo)
        {
            int folio = 0;
            switch (tipo)
            {
                case "visitante":
                    folio =  db.visitantes.Count();
                    break;
            }
            return folio + 1;
        }

    }
}