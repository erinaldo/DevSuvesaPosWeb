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

        public List<Area> ObtenerAreas()
        {
            try
            {
                var temp = from c in entities.Areas

                           select c;
                List<Area> result = temp.ToList<Area>();

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

        public List<Area> ObtenerAreas(int id)
        {
            try
            {
                var temp = from c in entities.Areas
                           where c.IdArea == id
                           select c;
                List<Area> result = temp.ToList<Area>();

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

        public int EditarAreas(int id, Area abono)
        {
            try
            {
                var p = entities.Areas.Find(id);
                Area Nuevo = p;                
                Nuevo.IdSucursal = abono.IdSucursal;
                //Nuevo.AbonoApartadosdetalles = abono.AbonoApartadosdetalle;

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
