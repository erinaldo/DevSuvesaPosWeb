using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Negocio.Logica;

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ajusteinventarioController : Controller
    {

        private Negocio.Logica.AjustesInventario db = new Negocio.Logica.AjustesInventario();

        [HttpPost]
        public IActionResult PostAjusteInventario(Datos.Models.AjusteInventario nuevo)
        {
            try
            {

                string resp = db.Crear(nuevo);

                if (resp.Equals("1"))
                {
                    return Ok(nuevo);
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
        public IActionResult GetAjusteInventario(bool pordescripcion,
                                            bool porconsecutivo,                                            
                                            string filtro)
        {

            var result = this.db.Buscar(pordescripcion, porconsecutivo, filtro);
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
