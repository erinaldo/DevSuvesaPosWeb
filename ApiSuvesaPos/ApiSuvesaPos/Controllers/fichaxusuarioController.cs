﻿using Microsoft.AspNetCore.Mvc;
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
    public class fichaxusuarioController : Controller
    {

        private Negocio.Logica.FichasxUsuario db = new Negocio.Logica.FichasxUsuario();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }


        [HttpPost]
        public IActionResult Registrar(Datos.Models.FichasxUsuario ficha)
        {
            try
            {
                string resp = db.Crear(ficha);

                if (resp.Equals("1"))
                {
                    return Ok(ficha);
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

            if (pornombre == false && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

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
