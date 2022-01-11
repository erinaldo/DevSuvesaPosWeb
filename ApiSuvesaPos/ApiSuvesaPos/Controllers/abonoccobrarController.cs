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
    public class abonoccobrarController : Controller
    {
        private Negocio.Logica.Abonoccobrar db = new Negocio.Logica.Abonoccobrar();

        [HttpPost]
        public IActionResult PostAbonocCobrar(Datos.Models.Abonoccobrar nuevo)
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
        public IActionResult GetAbonoccobrar()
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
