using Dapper;
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
                             Estado = true,
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

        public async Task<ResponseGeneric<int>> getIDClient(string cedula)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "[usp_Clientes_Obtener_ID_PorCedula]",
                         param: new
                         {
                            cedula
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<int>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<int>(ex);
            }
        }

        public async Task<ResponseGeneric<int>> getIDClient(string cedula, string nombre)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Clientes_Obtener_ID_PorCedula_PorNombre",
                         param: new
                         {
                             cedula,
                             nombre
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<int>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<int>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByCedula(BuscarClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Obtener_Cedula",
                         param: new
                         {
                             request.Cedula
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByNombre(BuscarClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Obtener_Nombre",
                         param: new
                         {
                             request.Nombre
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(ex);
            }
        }
        
        public async Task<ResponseGeneric<IEnumerable<FiltranClienteDTO>>> getClientByFiltro(BuscarClienteDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Obtener_Filtro",
                         param: new
                         {
                             request.Cedula,
                             request.Nombre
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<FiltranClienteDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> disableClient(int idCliente, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Desactivar",
                         param: new
                         {
                             idCliente,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<FiltranClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<FiltranClienteDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<FiltranClienteDTO>> enableClient(int idCliente, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.FiltranClienteDTO>
                    (
                         sql: "usp_Clientes_Activar",
                         param: new
                         {
                             idCliente,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<FiltranClienteDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<FiltranClienteDTO>(ex);
            }
        }
    }
}
