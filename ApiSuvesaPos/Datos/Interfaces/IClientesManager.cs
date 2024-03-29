﻿using Datos.Helpers;
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

        Task<ResponseGeneric<DTOs.ClienteDTO>> editClient(Datos.DTOs.ClienteDTO request);

        Task<ResponseGeneric<int>> getIDClient(string cedula);

        Task<ResponseGeneric<int>> getIDClient(string cedula, string nombre);

        Task<ResponseGeneric<IEnumerable<DTOs.FiltranClienteDTO>>> getClientByCedula(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<IEnumerable<DTOs.FiltranClienteDTO>>> getClientByNombre(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<IEnumerable<DTOs.FiltranClienteDTO>>> getClientByFiltro(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<DTOs.FiltranClienteDTO>> disableClient(int idCliente, string idUsuarioModificacion);

        Task<ResponseGeneric<DTOs.FiltranClienteDTO>> enableClient(int idCliente, string idUsuarioModificacion);

    }
}
