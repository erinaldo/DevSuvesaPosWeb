using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class AutorizacionAdelanto
    {
        public decimal Id { get; set; }
        public decimal IdAdelanto { get; set; }
        public string IdCajero { get; set; }
        public string IdAdmin { get; set; }
        public string CedulaRetira { get; set; }
        public string NombreRetira { get; set; }
        public bool Facturado { get; set; }
        public DateTime? FechaFacturacion { get; set; }
        public int? IdSucursal { get; set; }
    }
}
