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
        public string Cod_Articulo { get; set; }
        public string Descripcion { get; set; }
        public bool Actualizado { get; set; }
        public bool SoloContado { get; set; }
        public int CodPresentacion { get; set; }
        public string Barras { get; set; }
        public string barras2 { get; set; }
        public string barras3 { get; set; }
        public string SubFamilia { get; set; }
        public string SubUbicacion { get; set; }
        public int Proveedor { get; set; }
        //public long RebajaOtroArticulo { get; set; }
        public bool pantalla { get; set; }
        public string CODCABYS { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }

    }
}
