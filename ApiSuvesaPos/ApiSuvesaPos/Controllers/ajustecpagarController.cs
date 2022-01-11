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
    public class ajustecpagarController : Controller
    {
        private Negocio.Logica.Ajustecpagar db = new Negocio.Logica.Ajustecpagar();

        [HttpPost]
        public IActionResult PostAjustecpagar(Datos.Models.Ajustescpagar nuevo)
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
        public IActionResult GetAjustecpagar(bool pornombre, 
                                            bool pornumero, 
                                            bool porid,
                                            bool porfecha, 
                                            string filtro, 
                                            DateTime desde, 
                                            DateTime hasta)
        {

            var result = this.db.Buscar(pornombre, pornumero, porid,filtro,porfecha,desde,hasta);
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
