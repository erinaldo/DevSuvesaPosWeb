using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;

namespace Datos.Class
{
    class Actividades
    {
        private SeePOSContext entities;

        public Actividades()
        {
            entities = new SeePOSContext();
        }

        public int CrearActividad(Actividade Actividad) // crear Actividad apartir de objeto de creacion
        {
            try
            {
                entities.Actividades.Add(Actividad);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarActividad(int id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.Actividades.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Actividades> ObtenerActividades() //obtener lista actividades 
        {
            try
            {
                var temp = from c in entities.Actividades

                           select c;
                List<Actividades> result = temp.ToList<Actividades>();

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
    }
}
