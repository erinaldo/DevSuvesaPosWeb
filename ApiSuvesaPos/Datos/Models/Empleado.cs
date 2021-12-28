using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Empleado
    {
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public bool Activo { get; set; }
        public string Telefono { get; set; }
        public double Salario { get; set; }
        public string Puesto { get; set; }
        public string Codigo { get; set; }
        public int? IdSucursal { get; set; }
    }
}
