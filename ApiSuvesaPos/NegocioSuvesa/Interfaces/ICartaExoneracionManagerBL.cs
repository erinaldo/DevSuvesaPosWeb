﻿using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface ICartaExoneracionManagerBL
    {
        Task<ResponseGeneric<Datos.DTOs.CartaExoneracionDTO>> addCartaExoneracionEntry(Datos.DTOs.CartaExoneracionDTO request);
    }
}
