using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ServidorFtp
    {
        public decimal Id { get; set; }
        public bool TieneFtp { get; set; }
        public string LocalHost { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string UsuarioPublico { get; set; }
        public string ClavePublica { get; set; }
    }
}
