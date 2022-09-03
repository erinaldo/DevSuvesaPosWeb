using System;

namespace Datos.DTOs
{
    public class ReferenciasBancariasDTO
    {
        public string Sucursal { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public DateTime Fecha { get; set; }
    }
}
