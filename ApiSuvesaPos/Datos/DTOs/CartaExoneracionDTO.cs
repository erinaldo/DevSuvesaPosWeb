﻿using System;

namespace Datos.DTOs
{
    public class CartaExoneracionDTO
    {
        public string Cedula { get; set; }
        public int IdTipoExoneracion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVence { get; set; }
        public double PorcentajeCompra { get; set; }
        public double Impuesto { get; set; }
        public string Nota { get; set; }
    }
}
