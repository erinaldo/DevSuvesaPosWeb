﻿using System;

namespace APIFacturacionElectronica.Models
{
    public class RespuestaAutenticacion
    {
        
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
