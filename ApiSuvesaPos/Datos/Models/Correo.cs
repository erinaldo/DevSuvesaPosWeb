using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Correo
    {
        public string DireccionCorreo { get; set; }
        public string Clave { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
    }
}
