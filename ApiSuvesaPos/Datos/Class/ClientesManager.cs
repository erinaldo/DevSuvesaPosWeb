﻿using Dapper;
using Datos.Connection;
using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Class
{
    public class ClientesManager : IClientesManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public ClientesManager(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<DTOs.ClienteDTO>> addClientEntry(ClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.ClienteDTO>
                    (
                         sql: "usp_Clientes_AgregarInfo",
                         param: new
                         {
                             request.Cedula,
                             request.Nombre,
                             request.Observaciones,
                             telefono_01 = request.Telefono01,
                             telefono_02 = request.Telefono02,
                             fax_01 = request.Fax01,
                             fax_02 = request.Fax02,
                             e_mail = request.EMail,
                             request.Abierto,
                             request.Direccion,
                             request.Impuesto,
                             max_credito = request.MaxCredito,
                             Plazo_credito = request.PlazoCredito,
                             request.Descuento,
                             request.Empresa,
                             request.Tipoprecio,
                             request.Sinrestriccion,
                             request.Agente,
                             request.CodMonedaCredito,
                             Cliente_Moroso = request.ClienteMoroso,
                             request.Anulado,
                             request.OrdenCompra,
                             request.CorreoComprobante,
                             request.Actualizado,
                             request.DescuentoEspecial,
                             request.Relacionados,
                             request.Mag,
                             request.EnviarRecibo,
                             request.CorreoRecibo,
                             request.UsoInterno,
                             request.Fallecido,
                             request.IdSucursal,
                             request.IdTipoIdentificacion,
                             request.IdUsuarioCreacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<ClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch(Exception ex)
            {
                return new ResponseGeneric<ClienteDTO>(ex);
            }

        }
    }
}