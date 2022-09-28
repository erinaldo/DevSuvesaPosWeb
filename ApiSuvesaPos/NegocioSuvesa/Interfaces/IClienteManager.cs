﻿using Datos.Helpers;
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

        Task<ResponseGeneric<int>> getIDClient(string cedula);

        Task<ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> getClientByCedula(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> getClientByNombre(Datos.DTOs.BuscarClienteDTO request);

        Task<ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> removeClient(Datos.DTOs.BuscarClienteDTO request);
    }
}
