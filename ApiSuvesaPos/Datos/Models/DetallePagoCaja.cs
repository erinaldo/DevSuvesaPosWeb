using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class DetallePagoCaja
    {
        public long Id { get; set; }
        public double NumeroFactura { get; set; }
        public string TipoFactura { get; set; }
        public string FormaPago { get; set; }
        public string Referencia { get; set; }
        public string Documento { get; set; }
        public string ReferenciaTipo { get; set; }
        public string ReferenciaDoc { get; set; }
        public int Moneda { get; set; }
        public double TipoCambio { get; set; }
        public long IdOdp { get; set; }

        public virtual OpcionesDePago IdOdpNavigation { get; set; }
    }
}
