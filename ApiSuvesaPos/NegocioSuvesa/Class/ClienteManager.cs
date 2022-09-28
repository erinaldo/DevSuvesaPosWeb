﻿using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using NegocioSuvesa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioSuvesa.Class
{
    public class ClienteManager : IClienteManagerBL
    {
        private readonly IClientesManagerDA _clientesManager;
        private IValidaciones _validaciones;

        public ClienteManager(IClientesManagerDA clientesManager, IValidaciones validaciones)
        {
            _clientesManager = clientesManager;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<ClienteDTO>> addClientEntry(ClienteDTO request)
        {
            // Validaciones Cedula
            if(_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Cédula incorrecta");
            }

            // Validaciones Nombre 
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Nombre incorrecto");
            }

            // Validaciones Email 
            if (_validaciones.isEmpty(request.EMail) || !_validaciones.isEmail(request.EMail))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo electronico incorrecto");
            }

            // Validaciones CorreoComprobante 
            if (_validaciones.isEmpty(request.CorreoComprobante) || !_validaciones.isEmail(request.CorreoComprobante))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Correo Comprobante incorrecto");
            }

            // Validaciones Direccion 
            if (_validaciones.isEmpty(request.Direccion))
            {
                return new ResponseGeneric<ClienteDTO>("Error: Direccion requerida");
            }

            return await _clientesManager.addClientEntry(request);
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> getClientByCedula(BuscarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Cédula incorrecta");
            }

            return await _clientesManager.getClientByCedula(request);
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> getClientByNombre(BuscarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Nombre) || !_validaciones.isOnlyLetter(request.Nombre))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Nombre incorrecta");
            }

            return await _clientesManager.getClientByNombre(request);
        }

        public async Task<ResponseGeneric<int>> getIDClient(string cedula)
        {
            return await _clientesManager.getIDClient(cedula);
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> removeClient(BuscarClienteDTO request)
        {
            // Validaciones Cedula
            if (_validaciones.isEmpty(request.Cedula) || !_validaciones.isOnlyNumeric(request.Cedula))
            {
                return new ResponseGeneric<FiltranClienteDTO>("Error: Cédula incorrecta");
            }

            ResponseGeneric<int> idCliente = await getIDClient(request.Cedula);

            return await _clientesManager.removeClient(idCliente.Responses);
        }
    }
}
