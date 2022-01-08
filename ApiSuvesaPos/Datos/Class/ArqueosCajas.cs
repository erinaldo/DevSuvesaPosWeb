using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public class ArqueosCajas
    {
        SeePOSContext entities;

        public ArqueosCajas()
        {
            entities = new SeePOSContext();
        }

        public int CrearArqueosCajas(ArqueoCaja caja)
        {
            try
            {
                entities.ArqueoCajas.Add(caja);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarArqueosCajas(int id)


        {
            try
            {
                var p = entities.ArqueoCajas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArqueoCaja> ObtenerArqueosCajas()
        {
            try
            {
                var temp = from c in entities.ArqueoCajas

                           select c;
                List<ArqueoCaja> result = temp.ToList<ArqueoCaja>();

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

        public List<ArqueoCaja> ObtenerArqueosCajas(int id)
        {
            try
            {
                var temp = from c in entities.ArqueoCajas
                           where c.Id == id
                           select c;
                List<ArqueoCaja> result = temp.ToList<ArqueoCaja>();

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

        public int EditarArqueosCajas(int id, ArqueoCaja abono)
        {
            try
            {
                var p = entities.ArqueoCajas.Find(id);
                ArqueoCaja Nuevo = p;
                Nuevo.Id = abono.Id;
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
