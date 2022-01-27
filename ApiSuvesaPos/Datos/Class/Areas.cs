using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class Areas
    {
        SeePOSContext entities;

        public Areas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAreas(Area area)
        {
            try
            {
                entities.Areas.Add(area);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAreas(int id)
        {
            try
            {
                var p = entities.Areas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Area> ObtenerAreas(bool porId, string Filtro)
        {
            try
            {
                List<Area> result;

                if (porId == true)
                {
                    var temp = from c in entities.Areas
                               where c.IdArea == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Area>();
                }
                else
                {
                    var temp = from c in entities.Areas
                               where c.Descripcion.Contains(Filtro)
                               orderby c.Descripcion ascending
                               select c;
                    result = temp.ToList<Area>();
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

        public int EditarAreas(int id, Area area)
        {
            try
            {
                // Ojo
                //Falta agregar la relacion entra las tablas area con  areaarticulo y areaencargado

                var p = entities.Areas.Find(id);
                Area Nuevo = p;                
                Nuevo.IdSucursal = area.IdSucursal;
                Nuevo.Descripcion = area.Descripcion;
                Nuevo.Observaciones = area.Observaciones;                                

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
