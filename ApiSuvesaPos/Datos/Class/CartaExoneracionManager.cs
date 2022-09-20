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
    public class CartaExoneracionManager : ICartaExoneracionManagerDA
    {
        private readonly IConnectionManager _ConnectionManager;

        public CartaExoneracionManager(IConnectionManager connectionManager)
        {
            _ConnectionManager = connectionManager;
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> addCartaExoneracionEntry(CartaExoneracionDTO request, int idCliente)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.CartaExoneracionDTO>
                    (
                         sql: "usp_CartaExoneracion_Agregar",
                         param: new
                         {
                             Identificacion = idCliente,
                             request.IdTipoExoneracion,
                             request.NumeroDocumento,
                             request.FechaEmision,
                             request.FechaVence,
                             request.PorcentajeCompra,
                             request.Impuesto,
                             request.Nota,
                             Estado = true
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    CartaExoneracionDTO res = resultado.FirstOrDefault();
                    res.Cedula = request.Cedula;
                    return new ResponseGeneric<CartaExoneracionDTO>(res);
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<CartaExoneracionDTO>(ex);
            }
        }

        public async Task<ResponseGeneric<CartaExoneracionDTO>> removeCartaExoneracion(int idCliente)
        {
            try
            {
                //Realiza la conexión con la base de datos 
                using (var connection = _ConnectionManager.GetConnection(ConnectionManager.DEVCarlos))
                {
                    var resultado = await connection.QueryAsync<DTOs.CartaExoneracionDTO>
                    (
                         sql: "usp_CartaExoneracion_Eliminar",
                         param: new
                         {
                             Cedula = idCliente
                         },
                         commandType: CommandType.StoredProcedure, commandTimeout: 1200
                    );

                    return new ResponseGeneric<CartaExoneracionDTO>(resultado.FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<CartaExoneracionDTO>(ex);
            }
        }
    }
}
