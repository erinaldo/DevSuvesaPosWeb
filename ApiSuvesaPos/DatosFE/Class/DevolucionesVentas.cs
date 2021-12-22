using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    class DevolucionesVentas
    {
        private FEContext entities;

        public DevolucionesVentas()
        {
            entities = new FEContext();
        }

        public int CrearDevolucionesVentas(DevolucionesVenta articulo) // crear Devoluciones Ventas apartir de objeto de creacion
        {
            try
            {
                entities.DevolucionesVentas.Add(articulo);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int BorrarDevolucionesVenta(int id) // borrar Devoluciones Ventas apartir del id Actividad


        {
            try
            {
                var p = entities.DevolucionesVentas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<DevolucionesVenta> ObtenerDevolucionesVenta() //obtener lista Articulos devueltos
        {
            try
            {
                var temp = from c in entities.DevolucionesVentas

                           select c;
                List<DevolucionesVenta> result = temp.ToList<DevolucionesVenta>();

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
