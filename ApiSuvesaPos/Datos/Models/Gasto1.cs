using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Gasto1
    {
        public long Id { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public string Cedula { get; set; }
        public string Codigo { get; set; }
        public string CodigoArt { get; set; }
        public string Descripcion { get; set; }
        public double Existencia { get; set; }
        public double Cantidad { get; set; }
        public string Observaciones { get; set; }
        public long Idbodega { get; set; }
        public double Costo { get; set; }
        public int? IdSucursal { get; set; }
    }
}
