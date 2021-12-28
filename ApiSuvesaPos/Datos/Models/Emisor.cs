using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Emisor
    {
        public int Identificacion { get; set; }
        public int? Tipo { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Barrio { get; set; }
        public string Otrassenas { get; set; }
        public string CodigoPais { get; set; }
        public string NumeroTelefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
