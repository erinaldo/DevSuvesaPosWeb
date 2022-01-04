using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AdelantosVentasDetalles
    {
        SeePOSContext entities;

        public AdelantosVentasDetalles()
        {
            entities = new SeePOSContext();
        }

        public int CrearAdelantosVentasDetalles(AdelantoVentasDetalle venta)
        {
            try
            {
                entities.AdelantoVentasDetalles.Add(venta);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAdelantosVentasDetalles(int id)


        {
            try
            {
                var p = entities.AdelantoVentasDetalles.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AdelantoVentasDetalle> ObtenerAdelantosVentasDetalles()
        {
            try
            {
                var temp = from c in entities.AdelantoVentasDetalles

                           select c;
                List<AdelantoVentasDetalle> result = temp.ToList<AdelantoVentasDetalle>();

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

        public List<AdelantoVentasDetalle> ObtenerAdelantosVentasDetalles(int id)
        {
            try
            {
                var temp = from c in entities.AdelantoVentasDetalles
                           where c.IdVentaDetalle == id
                           select c;
                List<AdelantoVentasDetalle> result = temp.ToList<AdelantoVentasDetalle>();

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

        public int EditarAdelantosVentasDetalles(int id, AdelantoVentasDetalle abono)
        {
            try
            {
                var p = entities.AdelantoVentasDetalles.Find(id);
                AdelantoVentasDetalle Nuevo = p;
                
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
