using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Area
    {
        public decimal IdArea { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }
        public int IdSucursal { get; set; }

        public virtual Sucursale IdSucursalNavigation { get; set; }
    }
}
