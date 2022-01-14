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
    public class ajusteinventarioController : Controller
    {

        private Negocio.Logica.AjustesInventario db = new Negocio.Logica.AjustesInventario();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        [HttpPost]
        public IActionResult PostAjusteInventario(Datos.Models.AjusteInventario ajusteinventario)
        {
            try
            {

                string resp = db.Crear(ajusteinventario);
                if (resp.Equals("1"))
                {
                    return Ok("Ok");
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
        public IActionResult PutAjusteInventario(int id)
        {

            string resp = this.db.Anular(id);
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
        public IActionResult GetAjusteInventario(bool porid, string filtro)
        {
            if (porid == true && !this.Numerico(filtro))
            {
                return BadRequest("El parametro filtro no tiene el valor esperado. Se esperaba un valor numerico.");
            }

            var result = this.db.Buscar( porid, filtro);
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
