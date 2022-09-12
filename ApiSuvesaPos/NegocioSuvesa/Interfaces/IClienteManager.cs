using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Interfaces
{
    public interface IClienteManagerBL
    {
        Task<ResponseGeneric<Datos.DTOs.ClienteDTO>> addClientEntry(Datos.DTOs.ClienteDTO request);
    }
}
