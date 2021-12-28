using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class Bodega
    {
        public Bodega()
        {
            MovimientosBodegas = new HashSet<MovimientosBodega>();
        }

        public int IdBodega { get; set; }
        public string NombreBodega { get; set; }
        public string Observaciones { get; set; }
        public bool? Bloqueada { get; set; }
        public long IdSucursal { get; set; }

        public virtual ICollection<MovimientosBodega> MovimientosBodegas { get; set; }
    }
}
