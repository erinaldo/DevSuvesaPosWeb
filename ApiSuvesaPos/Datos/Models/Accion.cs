using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Accion
    {
        public long Id { get; set; }
        public long IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public long IdCategoria { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Observacion { get; set; }
        public bool Anulada { get; set; }
        public long IdSucursal { get; set; }
    }
}
