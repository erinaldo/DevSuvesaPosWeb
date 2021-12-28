using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class HojaCxC
    {
        public double? NumFactura { get; set; }
        public string Tipo { get; set; }
        public double? CodCliente { get; set; }
        public double? Identificacion { get; set; }
        public string NombreCliente { get; set; }
        public double? Orden { get; set; }
        public double? CedulaUsuario { get; set; }
        public double? PagoComision { get; set; }
        public double? SubTotal { get; set; }
        public double? Descuento { get; set; }
        public double? ImpVenta { get; set; }
        public double? Total { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? Vence { get; set; }
        public string CodEncargadoCompra { get; set; }
        public bool? Contabilizado { get; set; }
        public double? AsientoVenta { get; set; }
        public bool? ContabilizadoCventa { get; set; }
        public double? AsientoCosto { get; set; }
        public bool? Anulado { get; set; }
        public double? PagoImpuesto { get; set; }
        public bool? FacturaCancelado { get; set; }
        public double? NumApertura { get; set; }
        public bool? Entregado { get; set; }
        public double? CodMoneda { get; set; }
        public string MonedaNombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double? SubTotalGravada { get; set; }
        public double? SubTotalExento { get; set; }
        public double? Transporte { get; set; }
        public double? TipoCambio { get; set; }
        public string Observaciones { get; set; }
        public bool? Exonerar { get; set; }
        public bool? Taller { get; set; }
        public int? IdSucursal { get; set; }
    }
}
