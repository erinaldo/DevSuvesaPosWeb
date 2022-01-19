using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using APIFacturacionElectronica.Models;
using NegocioFE.Logica;

namespace APIFacturacionElectronica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class feController : Controller
    {

        private NegocioFE.EnvioComprobantes FE = new NegocioFE.EnvioComprobantes();

        [HttpPut]
        [Route("enviar")]        
        public IActionResult PutEnviarComprobanteElectronico(string id, string tipodoc)
        {
            try
            {

                string resp;

                switch (tipodoc.ToUpper())
                {
                    case "FACTURA":
                        resp = this.FE.EnviarFactura(id);
                        break;

                    case "DEVOLUCION":
                        resp = this.FE.EnviarDevolucion(id);
                        break;

                    case "MENSAJE":
                        resp = this.FE.EnviarMensajeReceptor(id);
                        break;

                    default:
                        resp = "No existe el valor";
                        break;
                }

                if (resp.Equals("1"))
                {
                    return Ok("");
                }
                else if (resp.Equals("No existe el valor"))
                {
                    return NotFound();
                }
                else
                {
                    throw new Exception(resp);
                }

            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

    }
}
