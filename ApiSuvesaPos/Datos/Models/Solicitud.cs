using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Solicitud
    {
        public decimal Idsolicitud { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool Anulado { get; set; }
        public string IdUsuariocreo { get; set; }
        public long IdSucursal { get; set; }
    }
}
