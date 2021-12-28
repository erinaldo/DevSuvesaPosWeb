using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Sucursale
    {
        public long Id { get; set; }
        public string NombreFiscal { get; set; }
        public string NombreComercial { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Alias { get; set; }
    }
}
