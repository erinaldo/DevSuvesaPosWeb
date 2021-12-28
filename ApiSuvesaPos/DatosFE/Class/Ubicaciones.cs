using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Ubicaciones
    {
        private FEContext entities;

        public Ubicaciones()
        {
            entities = new FEContext();
        }

        public int CrearActividad(Ubicacion ubicacion) // crear Ubicacion apartir de objeto de creacion
        {
            try
            {
                entities.Ubicacions.Add(ubicacion);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarActividad(int id) // borrar Ubicacion apartir del id Actividad


        {
            try
            {
                var p = entities.Ubicacions.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Ubicacion> ObtenerActividades() //obtener lista actividades 
        {
            try
            {
                var temp = from c in entities.Ubicacions

                           select c;
                List<Ubicacion> result = temp.ToList<Ubicacion>();

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
