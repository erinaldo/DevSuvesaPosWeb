using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;
using Microsoft.EntityFrameworkCore;

namespace DatosFE.Class
{
  public  class Ventas
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

        public int BorrarVenta(long id) // borrar Venta apartir del id Actividad


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

        public int EditarEstadoFactura (long id, string estado) // editar estado de Hacienda
        {
            try
            {
                var p = entities.Ventas.Find(id);
                Venta viejo = p;
                viejo.EstadoMh = estado;

                if(estado == "aceptado")
                {
                    viejo.EnviadoMh = true;
                }

                entities.Entry(viejo).State = EntityState.Modified;

                return entities.SaveChanges();


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerClaveFactura(long id) // Retorna la clave de venta
        {
            try
            {
                var p = entities.Ventas.Find(id);
                Venta viejo = p;

                if (viejo != null)
                {
                    string clave = viejo.ClaveMh;
                    return clave;
                }
                else
                {
                    return "No existe venta";
                }



            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public string ObtenerNumeroConsecutivoFactura(long id) // Retorna la Numero Consecutivo de venta
        {
            try
            {
                var p = entities.Ventas.Find(id);
                Venta viejo = p;

                if (viejo != null)
                {
                    string consecutivo = viejo.ConsecutivoMh;
                    return consecutivo;
                }
                else
                {
                    return "No existe venta";
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}
