using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    class IdentificacionTipos
    {
        private FEContext entities;

        public IdentificacionTipos()
        {
            entities = new FEContext();
        }

        public int CrearTipoIdentificacion(TiposIdentificacion id) // crear Tipos identificacion apartir de objeto de creacion
        {
            try
            {
                entities.TiposIdentificacions.Add(id);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarTipoIdentificacion(int id) // borrar Tipo Identificacion apartir del id Actividad


        {
            try
            {
                var p = entities.TiposIdentificacions.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<TiposIdentificacion> ObtenerTiposIdentificacion() //obtener lista Tipos Identificacion 
        {
            try
            {
                var temp = from c in entities.TiposIdentificacions

                           select c;
                List<TiposIdentificacion> result = temp.ToList<TiposIdentificacion>();

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
