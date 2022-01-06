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
    public class mensajereceptorController : Controller
    {

        private NegocioFE.Logica.MensajeReceptor db = new NegocioFE.Logica.MensajeReceptor();

        [HttpPost]
        public IActionResult PostCrearMensajeReceptor(List<DatosFE.Models.MensajeReceptor> Estado)
        {
            try
            {

                string resp = db.Crear(Estado);
                if (resp.Equals("1"))
                {
                    return CreatedAtRoute("DefaultApi", new { Estado }, Estado);
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

        [HttpGet]
        public IActionResult GetObtenerMensejeReceptor(bool entreFechas, DateTime Desde, DateTime Hasta, bool porEstado, string estado)
        {

            var result = this.db.Buscar(entreFechas, porEstado, estado, Desde, Hasta);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }
    }
}
