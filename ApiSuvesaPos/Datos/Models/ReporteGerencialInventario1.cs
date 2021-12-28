using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class ReporteGerencialInventario1
    {
        public long Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Presentacion { get; set; }
        public string Proveedor { get; set; }
        public string UltimaCompra { get; set; }
        public string UltimaVenta { get; set; }
        public double Mes12A { get; set; }
        public double Mes11A { get; set; }
        public double Mes10A { get; set; }
        public double Mes09A { get; set; }
        public double Mes08A { get; set; }
        public double Mes07A { get; set; }
        public double Mes06A { get; set; }
        public double Mes05A { get; set; }
        public double Mes04A { get; set; }
        public double Mes03A { get; set; }
        public double Mes02A { get; set; }
        public double Mes01A { get; set; }
        public double MesActual { get; set; }
        public double SaldoActual { get; set; }
        public double ComprasMesActual { get; set; }
        public double CostoUltimaCompra { get; set; }
        public double PrecioVentaPromedio { get; set; }
        public double TotalVentaMes { get; set; }
        public double MaxDescuento { get; set; }
        public double TotalCostoMes { get; set; }
        public double UtilidadMes { get; set; }
        public string Ubicacion { get; set; }
    }
}
