using System.Collections.Generic;

namespace ApiSuvesaPos.DTOs
{
    public class ClienteDTOInput
    {
        ClienteDTO Cliente { get; set; }
        IEnumerable<EncargadoComprasDTO> EncargadoCompras { get; set; }
        IEnumerable<ReferenciasBancariasDTO> ReferenciasBancarias { get; set; }
        IEnumerable<ReferenciaComercialDTO> ReferenciasComerciales { get; set; }
        CartaExoneracionDTO CartaExoneracion { get; set; }
    }
}
