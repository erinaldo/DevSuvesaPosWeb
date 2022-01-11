using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AgentesVentas
    {
        SeePOSContext entities;

        public AgentesVentas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAgenteVentas(AgenteVenta agente)
        {
            try
            {
                entities.AgenteVentas.Add(agente);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAgenteVenta(int id)


        {
            try
            {
                var p = entities.AgenteVentas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AgenteVenta> ObtenerAgenteVentas(string nombre)
        {
            try
            {
                var temp = from c in entities.AgenteVentas
                           //filtrar por concidencia del nombre.
                           select c;
                List<AgenteVenta> result = temp.ToList<AgenteVenta>();

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

        public List<AgenteVenta> ObtenerAgenteVentas(int id)
        {
            try
            {
                var temp = from c in entities.AgenteVentas
                           where c.Id == id
                           select c;
                List<AgenteVenta> result = temp.ToList<AgenteVenta>();

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

        public int EditarAgenteVentas(int id, AgenteVenta abono)
        {
            try
            {
                var p = entities.AgenteVentas.Find(id);
                AgenteVenta Nuevo = p;
                
                
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
