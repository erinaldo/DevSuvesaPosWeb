using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ClientesApp
    {
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Img { get; set; }
        public bool GoogleSign { get; set; }
    }
}
