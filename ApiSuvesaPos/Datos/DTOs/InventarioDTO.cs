using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class InventarioDTO
    {
        public long Codigo { get; set; }
        public long Cod_Articulo { get; set; }
        public long Descripcion { get; set; }
        public long Actualizado { get; set; }
        public long SoloContado { get; set; }
        public long CodPresentacion { get; set; }
        public long Barras { get; set; }
        public long barras2 { get; set; }
        public long barras3 { get; set; }
        public long SubFamilia { get; set; }
        public long SubUbicacion { get; set; }
        public long Proveedor { get; set; }
        public long RebajaOtroArticulo { get; set; }
        public long pantalla { get; set; }
        public long CODCABYS { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }

    }
}
