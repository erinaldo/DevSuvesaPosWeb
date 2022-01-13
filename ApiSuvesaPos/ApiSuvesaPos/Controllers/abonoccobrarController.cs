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
    public class abonoccobrarController : Controller
    {
        private Negocio.Logica.Abonoccobrar db = new Negocio.Logica.Abonoccobrar();

        private bool Numerico(string text)
        {
            double test;
            return double.TryParse(text, out test);
        }

        [HttpPost]
        public IActionResult PostAbonocCobrar(Datos.Models.Abonoccobrar nuevo)
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
