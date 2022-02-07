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
    public class preabonoccobrarController : Controller
    {

        private Negocio.Logica.PreAbonocCobrar db = new Negocio.Logica.PreAbonocCobrar();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }


        [HttpPost]
        public IActionResult Registrar(Datos.Models.PreAbonocCobrar preabono)
        {
            try
            {
                string resp = db.Crear(preabono);

                if (resp.Equals("1"))
                {
                    return Ok(preabono);
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
