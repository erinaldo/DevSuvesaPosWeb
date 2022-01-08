using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Consecutivo
    {
        public decimal Consecutivo1 { get; set; }
        public int IdSucursal { get; set; }

        public virtual Sucursale IdSucursalNavigation { get; set; }
    }
}
