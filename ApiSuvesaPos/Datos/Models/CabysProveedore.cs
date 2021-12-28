using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class CabysProveedore
    {
        public decimal Id { get; set; }
        public string Clave { get; set; }
        public string Consecutivo { get; set; }
        public string Cedula { get; set; }
        public string Proveedor { get; set; }
        public string Descripcion { get; set; }
        public string Cabys { get; set; }
    }
}
