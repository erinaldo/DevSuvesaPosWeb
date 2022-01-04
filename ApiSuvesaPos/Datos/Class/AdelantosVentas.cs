using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AdelantosVentas
    {
        SeePOSContext entities;

        public AdelantosVentas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAdelantoVenta(AdelantoVenta venta)
        {
            try
            {
                entities.AdelantoVentas.Add(venta);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoApartado(int id)


        {
            try
            {
                var p = entities.AdelantoVentas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AdelantoVenta> ObtenerAbonoApartado()
        {
            try
            {
                var temp = from c in entities.AdelantoVentas

                           select c;
                List<AdelantoVenta> result = temp.ToList<AdelantoVenta>();

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

        public List<AdelantoVenta> ObtenerAbonoApartado(int id)
        {
            try
            {
                var temp = from c in entities.AdelantoVentas
                           where c.Id == id
                           select c;
                List<AdelantoVenta> result = temp.ToList<AdelantoVenta>();

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

        public int EditarAbonoApartado(int id, AdelantoVenta abono)
        {
            try
            {
                var p = entities.AdelantoVentas.Find(id);
                AdelantoVenta Nuevo = p;
                Nuevo.CodCliente = abono.CodCliente;
                Nuevo.NombreCliente = abono.NombreCliente;
                Nuevo.Fecha = abono.Fecha;
                Nuevo.Observaciones = abono.Observaciones;
                Nuevo.CodMoneda = abono.CodMoneda;
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
