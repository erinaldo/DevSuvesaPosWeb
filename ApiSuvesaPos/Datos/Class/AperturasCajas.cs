using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AperturasCajas
    {
        SeePOSContext entities;

        public AperturasCajas()
        {
            entities = new SeePOSContext();
        }

        public int CrearAperturasCajas(Aperturacaja Abono)
        {
            try
            {
                entities.Aperturacajas.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAperturasCajas(int id)


        {
            try
            {
                var p = entities.Aperturacajas.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Aperturacaja> ObtenerAperturasCajas()
        {
            try
            {
                var temp = from c in entities.Aperturacajas

                           select c;
                List<Aperturacaja> result = temp.ToList<Aperturacaja>();

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

        public List<Aperturacaja> ObtenerAperturasCajas(int id)
        {
            try
            {
                var temp = from c in entities.Aperturacajas
                           where c.NumCaja == id
                           select c;
                List<Aperturacaja> result = temp.ToList<Aperturacaja>();

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

        public int EditarAperturasCajas(int id, Aperturacaja abono)
        {
            try
            {
                var p = entities.Aperturacajas.Find(id);
                Aperturacaja Nuevo = p;
                Nuevo.Fecha = abono.Fecha;
                Nuevo.Observaciones = abono.Observaciones;                
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
