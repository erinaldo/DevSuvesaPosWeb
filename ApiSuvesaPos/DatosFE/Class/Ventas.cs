using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    class Ventas
    {
        private FEContext entities;

        public Ventas()
        {
            entities = new FEContext();
        }

        public int CrearVenta(Venta venta) // crear Venta apartir de objeto de creacion
        {
            try
            {
                entities.Ventas.Add(venta);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarVenta(int id) // borrar Venta apartir del id Actividad


        {
            try
            {
                var p = entities.Ventas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Venta> ObtenerVentas() //obtener lista Ventas 
        {
            try
            {
                var temp = from c in entities.Ventas

                           select c;
                List<Venta> result = temp.ToList<Venta>();

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
