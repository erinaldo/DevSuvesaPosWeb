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
    public class agenteventaController : Controller
    {

        private Negocio.Logica.Agente_Ventas db = new Negocio.Logica.Agente_Ventas();

        [HttpPost]
        public IActionResult PostAgenteVenta(Datos.Models.AgenteVenta nuevo)
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

        [HttpPut]
        public IActionResult PutAgenteVenta(int id ,Datos.Models.AgenteVenta agenteventa)
        {
            try
            {

                string resp = db.Editar(id, agenteventa);

                if (resp.Equals("1"))
                {
                    return Ok(agenteventa);
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
        public IActionResult GetAgenteVenta(string nombre)
        {

            var result = this.db.Buscar(nombre);
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
        public IActionResult DeleteAgenteVenta(int id)
        {

            var result = this.db.Eliminar(id);
            if (result != null)
            {
                return Ok("Ok");
            }
            else
            {
                return new NoContentResult();
            }
        }

    }
}
