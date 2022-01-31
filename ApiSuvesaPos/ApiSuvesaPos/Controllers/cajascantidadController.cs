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
    public class cajascantidadController: Controller
    {


        private Negocio.Logica.Cajas_Cantidad db = new Negocio.Logica.Cajas_Cantidad();

        [HttpGet]
        public IActionResult Buscar()
        {

            var result = this.db.Buscar();
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
