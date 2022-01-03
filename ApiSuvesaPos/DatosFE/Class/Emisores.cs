using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
  public   class Emisores
    {
        private FEContext entities;

        public Emisores()
        {
            entities = new FEContext();
        }

        public int CrearEmisores(Emisor emisor) // crear emisores s apartir de objeto de creacion
        {
            try
            {
                entities.Emisors.Add(emisor);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarEmisores(int id) // borrar Emisores apartir del id Actividad


        {
            try
            {
                var p = entities.Emisors.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Emisor> ObtenerEmisores() //obtener lista Emisores
        {
            try
            {
                var temp = from c in entities.Emisors

                           select c;
                List<Emisor> result = temp.ToList<Emisor>();

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
