using Datos.DTOs;
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
    public class InventarioManagerBL : IInventarioManagerBL
    {

        private readonly IInventariosManagerDA _inventarioManager;
        private IValidaciones _validaciones;

        public InventarioManagerBL(IInventariosManagerDA inventarioManager, IValidaciones validaciones)
        {
            _inventarioManager = inventarioManager;
            _validaciones = validaciones;
        }

        public async Task<ResponseGeneric<InventarioDTO>> addInventario(InventarioDTO request)
        {
            return await _inventarioManager.addInventario(request);
        }

        public async Task<ResponseGeneric<InventarioDTO>> editInventario(InventarioDTO request)
        {
            return await _inventarioManager.editInventario(request);
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo)
        {
            return await _inventarioManager.getIDInventario(cod_articulo);
        }

        public async Task<ResponseGeneric<int>> getIDInventario(string cod_articulo, string descripcion)
        {
            return await _inventarioManager.getIDInventario(cod_articulo, descripcion);
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByCodigo(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getInventarioByCodigo(request);
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByDescripcion(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getInventarioByDescripcion(request);
        }

        public async Task<ResponseGeneric<IEnumerable<InventarioDTO>>> getInventarioByFiltro(BuscarInventarioDTO request)
        {
            return await _inventarioManager.getInventarioByFiltro(request);
        }

        public async Task<ResponseGeneric<InventarioDTO>> disableInventario(EliminarInventarioDTO request)
        {
            ResponseGeneric<int> idInventario = await getIDInventario(request.Cod_Articulo, request.Descripcion);

            return await _inventarioManager.disableInventario(idInventario.Responses, request.IdUsuarioModificacion);
        }

        public async Task<ResponseGeneric<InventarioDTO>> enableInventario(EliminarInventarioDTO request)
        {
            ResponseGeneric<int> idInventario = await getIDInventario(request.Cod_Articulo, request.Descripcion);

            return await _inventarioManager.enableInventario(idInventario.Responses, request.IdUsuarioModificacion);
        }

    }
}
