using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IClientesManagerDA
    {
        Task<ResponseGeneric<DTOs.ClienteDTO>> addClientEntry(Datos.DTOs.ClienteDTO request);

        Task<ResponseGeneric<int>> getIDClient(string cedula);

    }
}
