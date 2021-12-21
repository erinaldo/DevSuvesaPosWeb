﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DatosFE.Models
{
    public partial class ViewTemp
    {
        public decimal Id { get; set; }
        public string BasedeDatos { get; set; }
        public string TipoDoc { get; set; }
        public string Tipo { get; set; }
        public string EstadoMh { get; set; }
        public string Consecutivo { get; set; }
        public string FechaEmision { get; set; }
        public double? TotalComprobante { get; set; }
        public int Reenviar { get; set; }
    }
}
