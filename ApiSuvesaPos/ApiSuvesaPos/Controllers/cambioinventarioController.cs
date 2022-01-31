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
    public class cambioinventarioController : Controller
    {


        private Negocio.Logica.CambioInventario db = new Negocio.Logica.CambioInventario();


        [HttpPost]
        public IActionResult Registrar(Datos.Models.CambioInventario cambio)
        {
            try
            {
                string resp = db.Crear(cambio);

                if (resp.Equals("1"))
                {
                    return Ok(cambio);
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

        [HttpDelete]
        public IActionResult Eliminar(int id)
        {
            try
            {

                string resp = db.BorrarCambioInventario(id);
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
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

    }
}
