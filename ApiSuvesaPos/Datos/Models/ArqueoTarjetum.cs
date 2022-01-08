using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ArqueoTarjetum
    {
        public int Id { get; set; }
        public int IdArqueo { get; set; }
        public int IdTarjeta { get; set; }
        public int? IdSucursal { get; set; }
        public double Monto { get; set; }

        public virtual ArqueoCaja IdArqueoNavigation { get; set; }
        public virtual Sucursale IdSucursalNavigation { get; set; }
    }
}
