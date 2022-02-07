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
    public class descuentoController : Controller
    {

        private Negocio.Logica.Descuentos db = new Negocio.Logica.Descuentos();


        [HttpPost]
        public IActionResult Registrar(Datos.Models.Descuento descuento)
        {
            try
            {
                string resp = db.Crear(descuento);

                if (resp.Equals("1"))
                {
                    return Ok(descuento);
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
        public IActionResult Actualizar(int id, Datos.Models.Descuento descuento)
        {
            try
            {

                string resp = db.Editar(id, descuento);
                if (resp.Equals("1"))
                {
                    return Ok(descuento);
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

        [HttpGet]
        public IActionResult Buscar(decimal id)
        {

            var result = this.db.Buscar(id);
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
        public IActionResult Eliminar(decimal id)
        {
            try
            {

                string resp = db.Eliminar(id);
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
