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
    public class monedaController : Controller
    {


        private Negocio.Logica.Monedas db = new Negocio.Logica.Monedas();


        [HttpPost]
        public IActionResult Registrar(Datos.Models.Moneda moneda)
        {
            try
            {
                string resp = db.Crear(moneda);

                if (resp.Equals("1"))
                {
                    return Ok(moneda);
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
        public IActionResult Actualizar(int id, Datos.Models.Moneda moneda)
        {
            try
            {

                string resp = db.Editar(id, moneda);
                if (resp.Equals("1"))
                {
                    return Ok(moneda);
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
        public IActionResult Buscar(bool pornombre, string filtro)
        {

            var result = this.db.Buscar(pornombre, filtro);
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
