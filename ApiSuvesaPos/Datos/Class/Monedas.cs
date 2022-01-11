using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class Monedas
    {

        private SeePOSContext entities;

        public Monedas()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Moneda bodega) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Monedas.Add(bodega);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Moneda> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Moneda> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Monedas
                                   // usar un like
                               select c;

                    result = temp.ToList<Models.Moneda>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Monedas
                               where c.CodMoneda == Convert.ToInt32(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Moneda>();
                }

                if (result.Count > 0)
                {
                    return result;
                }
                else
                {
                    return result = null;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Editar(long id, Models.Moneda nuevo)
        {
            try
            {
                var p = entities.Monedas.Find(id);
                Models.Moneda viejo = p;

                if (viejo != null)
                {
                    viejo.MonedaNombre = nuevo.MonedaNombre;
                    viejo.ValorCompra = nuevo.ValorCompra;
                    viejo.ValorVenta = nuevo.ValorVenta;
                    viejo.Simbolo = nuevo.Simbolo;

                    entities.Entry(viejo).State = EntityState.Modified;

                    return entities.SaveChanges();
                }
                else
                {
                    return 0;// no se encotro el registro solicitado.
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Borrar(long id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.Monedas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
