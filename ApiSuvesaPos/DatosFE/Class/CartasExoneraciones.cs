using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
   public  class CartasExoneraciones
    {
        private FEContext entities;

        public CartasExoneraciones()
        {
            entities = new FEContext();
        }

        public int CrearCartaExoneracion(CartaExoneracion Carta) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.CartaExoneracions.Add(Carta);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarCartaExoneracion(int id) // borrar Actividad apartir del id Actividad


        {
            try
            {
                var p = entities.CartaExoneracions.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<CartaExoneracion> ObtenerCartaExoneracion() //obtener lista CartasdeExoneracion 
        {
            try
            {
                var temp = from c in entities.CartaExoneracions

                           select c;
                List<CartaExoneracion> result = temp.ToList<CartaExoneracion>();

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
