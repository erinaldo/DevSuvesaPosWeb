using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    class Compras
    {

        SeePOSContext entities;

        public Compras()
        {
            entities = new SeePOSContext();
        }


        public int CrearCompras(Models.Compra compra)
        {
            try
            {
                entities.Compras.Add(compra);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarCompra(long id)
        {
            try
            {
                var p = entities.Compras.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Models.Compra> ObtenerCompras(bool porId, string Filtro)
        {
            try
            {
                List<Models.Compra> result;

                if (porId == true)
                {
                    var temp = from c in entities.Compras
                              // where c.IdArea == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Models.Compra>();
                }
                else
                {
                    var temp = from c in entities.Compras
                              // where c.Descripcion.Contains(Filtro)
                              // orderby c.Descripcion ascending
                               select c;
                    result = temp.ToList<Models.Compra>();
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

        public int EditarCompras(int id, Models.Compra area)
        {
            try
            {
                // Ojo
                //Falta agregar la relacion entra las tablas area con  areaarticulo y areaencargado

                var p = entities.Areas.Find(id);
                Area Nuevo = p;
                //Nuevo.IdSucursal = area.IdSucursal;
                //Nuevo.Descripcion = area.Descripcion;
                //Nuevo.Observaciones = area.Observaciones;

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
