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
    public class configuracionesController : Controller
    {
        private NegocioFE.Logica.Configuraciones db = new NegocioFE.Logica.Configuraciones();

        [HttpPost]
        public IActionResult PostConfiguraciones(DatosFE.Models.Configuracione conf)
        {
            try
            {

                string resp = db.Crear(conf);

                if (resp.Equals("1"))
                {
                    return Ok(conf);
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
        [Route("cedula")]
        public IActionResult GetConfiguraciones(string cedula)
        {

            var result = this.db.Obtener(cedula);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return new NoContentResult();
            }
        }

        [HttpGet]
        public IActionResult GetConfiguraciones()
        {

            var result = this.db.Obtener("");
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
