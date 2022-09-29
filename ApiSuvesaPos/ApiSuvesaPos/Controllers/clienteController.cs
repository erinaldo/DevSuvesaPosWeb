using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Negocio.Logica;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Datos.Interfaces;

namespace ApiSuvesaPos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class clienteController : Controller
    {
        public NegocioSuvesa.Interfaces.IClienteManagerBL clientesManager;

        public clienteController(NegocioSuvesa.Interfaces.IClienteManagerBL clientesManager)
        {
            this.clientesManager = clientesManager;
        }

        private Negocio.Logica.Clientes db = new Negocio.Logica.Clientes();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>> Registrar([FromBody] Datos.DTOs.ClienteDTO cliente)
        {
            try
            {
                return await clientesManager.addClientEntry(cliente);   
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.ClienteDTO>(ex);
            }
        }

        [HttpPut]
        public IActionResult Actualizar(int id, Datos.Models.Cliente cliente)
        {
            try
            {

                string resp = db.Editar(id, cliente);
                double test;
                if (double.TryParse(resp, out test))// Si el resultado es numerico
                {
                    if (test > 0)//Si el resultado es mayor que cero
                    {
                        return Ok("Ok");
                    }
                    else
                    {
                        throw new Exception(resp);
                    }
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

        /// <summary>
        /// Obtiene un cliente por cedula
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> BuscarCedula([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {
            try
            {   
                return await clientesManager.getClientByCedula(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>(ex);
            }

            //if (pornombre == false && !this.Numerico(filtro))
            //{
            //    return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            //}

            //var result = this.db.Buscar(pornombre, filtro);
            //if (result != null)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return new NoContentResult();
            //}
        }

        /// <summary>
        /// Obtiene un cliente por nombre
        /// </summary>
        /// <returns>El cliente ingresado</returns>
        /// <response code="200">Cuando le ejecución es exitosa (existan o no resultados)</response>
        /// <response code="401">Cuando no se recibe ApiKey válido en el header del request</response>
        /// <response code="500">Cuando exista un error asociado a la ejecución de la operación</response>
        [HttpPost]
        [Route("/[controller]/[action]")]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> BuscarNombre([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {
            try
            {
                return await clientesManager.getClientByNombre(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>(ex);
            }

            //if (pornombre == false && !this.Numerico(filtro))
            //{
            //    return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            //}

            //var result = this.db.Buscar(pornombre, filtro);
            //if (result != null)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return new NoContentResult();
            //}
        }

        [HttpDelete]
        public async Task<Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>> Eliminar([FromBody] Datos.DTOs.BuscarClienteDTO request)
        {

            try
            {
                return await clientesManager.removeClient(request);
            }
            catch (Exception ex)
            {
                return new Datos.Helpers.ResponseGeneric<Datos.DTOs.FiltranClienteDTO>(ex);
            }

            //try
            //{

            //    string resp = db.Eliminar(id);
            //    double test;
            //    if (double.TryParse(resp, out test))// Si el resultado es numerico
            //    {
            //        if (test > 0)//Si el resultado es mayor que cero
            //        {
            //            return Ok("Ok");
            //        }
            //        else
            //        {
            //            throw new Exception(resp);
            //        }
            //    }
            //    else if (resp.Equals("No existe el valor"))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw new Exception(resp);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    return new BadRequestResult();
            //}
        }

    }
}
