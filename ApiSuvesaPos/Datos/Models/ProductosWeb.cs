using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ProductosWeb
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public int CodigoCategoria { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public double PrecioIva { get; set; }
        public double? PrecioIvamag { get; set; }
        public bool Promo { get; set; }
        public double DescuentoPromo { get; set; }
        public double PrecioIvapromo { get; set; }
        public double? PrecioIvapromoMag { get; set; }
        public double Existencia { get; set; }
        public string Espesificaciones { get; set; }
        public bool Mag { get; set; }
    }
}
