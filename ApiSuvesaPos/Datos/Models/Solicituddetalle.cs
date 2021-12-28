using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Solicituddetalle
    {
        public decimal Idsolicituddetalle { get; set; }
        public decimal Idsolicitud { get; set; }
        public decimal Codigo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public string Nota { get; set; }
        public bool Empaquetadosolicitud { get; set; }
        public bool Empaquetadoanulacion { get; set; }
    }
}
