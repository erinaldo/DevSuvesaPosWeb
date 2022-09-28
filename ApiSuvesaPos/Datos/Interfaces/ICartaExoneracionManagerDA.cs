using Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface ICartaExoneracionManagerDA
    {
        Task<ResponseGeneric<DTOs.CartaExoneracionDTO>> addCartaExoneracionEntry(Datos.DTOs.CartaExoneracionDTO request, int idCliente);

        Task<ResponseGeneric<DTOs.CartaExoneracionDTO>> removeCartaExoneracion(int idCliente);

        Task<ResponseGeneric<DTOs.CartaExoneracionDTO>> getCartaExoneracionByCedula(int idCliente);
    }
}
