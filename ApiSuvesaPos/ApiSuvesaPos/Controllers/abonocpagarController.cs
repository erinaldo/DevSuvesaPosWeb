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
    public class abonocpagarController : Controller
    {


        private Negocio.Logica.Abonocpagar db = new Negocio.Logica.Abonocpagar();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        [HttpPost]
        public IActionResult PostAbonocCobrar(Datos.Models.Abonocpagar nuevo)
        {
            try
            {

                string resp = db.Crear(nuevo);

                if (resp.Equals("2"))
                {
                    return Ok("OK");
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

        [HttpPut]
        public IActionResult PutAbonocCobrar(long id, bool eliminacheque)
        {

            string resp = this.db.Anular(id, eliminacheque);
            if (resp.Equals("1"))
            {
                return Ok("Ok");
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

        [HttpGet]
        public IActionResult GetAbonoccobrar(bool porid, string filtro)
        {

            if (porid == true && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

            var result = this.db.Buscar(porid, filtro);
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
