using Dapper;
using Datos.Connection;
using Datos.DTOs;
using Datos.Helpers;
using Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Class
{
    public class InventariosManagerDA : IInventariosManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public InventariosManagerDA(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<InventarioDTO>> addInventario(InventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Agregar",
                         param: new
                         {
                             request.Cod_Articulo,
                             request.Barras,
                             request.Descripcion,
                             request.SubFamilia,
                             request.SubUbicacion,
                             request.Proveedor,
                             request.pantalla,
                             request.barras2,
                             request.barras3,
                             request.Actualizado,
                             request.SoloContado,
                             request.CODCABYS,
                             Estado = true,
                             request.IdUsuarioCreacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }
        
        public async Task<ResponseGeneric<InventarioDTO>> editInventario(InventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Editar",
                         param: new
                         {
                             request.Codigo,
                             request.Cod_Articulo,
                             request.Barras,
                             request.Descripcion,
                             request.SubFamilia,
                             request.SubUbicacion,
                             request.Proveedor,
                             request.pantalla,
                             request.barras2,
                             request.barras3,
                             request.Actualizado,
                             request.SoloContado,
                             request.CODCABYS,
                             Estado = true,
                             request.IdUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Inventarios_Obtener_ID",
                         param: new
                         {
                             Cod_Articulo = cod_articulo
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

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo, string descripcion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<int>
                    (
                         sql: "usp_Inventarios_Obtener_ID_PorCodigo_PorDescripcion",
                         param: new
                         {
                             Cod_Articulo = cod_articulo,
                             descripcion
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

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByCodigo(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Obtener_Codigo",
                         param: new
                         {
                             request.Cod_Articulo,
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<InventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<InventarioDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByDescripcion(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Obtener_Descripcion",
                         param: new
                         {
                             request.Descripcion,
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<InventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<InventarioDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByFiltro(BuscarInventarioDTO request)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Obtener_Filtro",
                         param: new
                         {
                             request.Cod_Articulo,
                             request.Descripcion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<IEnumerable<InventarioDTO>>(resultado);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<IEnumerable<InventarioDTO>>(ex);
            }
        }

        public async Task<ResponseGeneric<InventarioDTO>> disableInventario(int idInventario, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Desactivar",
                         param: new
                         {
                             idInventario,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<InventarioDTO>> enableInventario(int idInventario, string idUsuarioModificacion)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.InventarioDTO>
                    (
                         sql: "usp_Inventarios_Activar",
                         param: new
                         {
                             idInventario,
                             idUsuarioModificacion
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<InventarioDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<InventarioDTO>(ex);
            }
        }

    }
}
