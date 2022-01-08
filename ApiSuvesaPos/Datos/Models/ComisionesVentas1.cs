﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ComisionesVentas1
    {
        public double? NumDoc { get; set; }
        public string TipoDoc { get; set; }
        public string TipoFac { get; set; }
        public DateTime? Fecha { get; set; }
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Empleado { get; set; }
        public int? CodMoneda { get; set; }
        public double? SubTotalVentaBruta { get; set; }
        public double MaxComision { get; set; }
        public double? ComisionVentaBruta { get; set; }
        public int SubTotalDevoluciones { get; set; }
        public int ComisionDevoluciones { get; set; }
        public long? IdFac { get; set; }
        public string NombreCliente { get; set; }
        public long IdDetFac { get; set; }
        public int TransporteVentas { get; set; }
        public int TransporteVentasDevueltas { get; set; }
        public double MontoImpuesto { get; set; }
        public int DevolucionesImpuesto { get; set; }
        public string Agente { get; set; }
        public int Id { get; set; }
        public long? NumCaja { get; set; }
    }
}
