using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Negocio.Logica;
using Negocio;

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apartadoController : Controller
    {

        private Negocio.Logica.Apartados db = new Negocio.Logica.Apartados();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        [HttpGet]
        public IActionResult Buscar(bool porNombre, string filtro)
        {

            if (porNombre == false && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

            var result = this.db.cargarApartadosPendientes(porNombre, filtro);
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
