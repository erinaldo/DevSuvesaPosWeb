using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models
{
    public partial class SaldoApartado
    {
        public long IdApartado { get; set; }
        public long IdCliente { get; set; }
        public double? Saldo { get; set; }
    }
}
