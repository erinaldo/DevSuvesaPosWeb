using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class PreTomaGeneral
    {
        public decimal IdPreToma { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public bool Aplicado { get; set; }
        public string Encargado { get; set; }
        public int? IdSucursal { get; set; }

        public virtual Sucursale IdSucursalNavigation { get; set; }
    }
}
