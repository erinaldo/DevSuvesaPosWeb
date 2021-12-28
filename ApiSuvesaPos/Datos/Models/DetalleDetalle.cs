using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetalleDetalle
    {
        public decimal Id { get; set; }
        public decimal IdVentaDetalle { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Codigo { get; set; }
        public double Cantidad { get; set; }
        public string Tipo { get; set; }
    }
}
