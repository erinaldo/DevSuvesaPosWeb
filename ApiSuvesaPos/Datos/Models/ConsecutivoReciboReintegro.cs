using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ConsecutivoReciboReintegro
    {
        public string Recibo { get; set; }
        public int IdSucursal { get; set; }

        public virtual Sucursale IdSucursalNavigation { get; set; }
    }
}
