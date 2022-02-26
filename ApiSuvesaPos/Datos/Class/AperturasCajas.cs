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

        public int CrearAperturasCajas(Aperturacaja apertura)
        {
            try
            {
                entities.Aperturacajas.Add(apertura);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int AnularAperturasCajas(long id)
        {
            try
            {
                var p = entities.Aperturacajas.Find(id);
                Aperturacaja Nuevo = p;                
                Nuevo.Anulado = true;            

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Aperturacaja> ObtenerAperturasCajas(bool porId, string Filtro)
        {
            try
            {

                List<Aperturacaja> result;

                if (porId == true)
                {
                    var temp = from c in entities.Aperturacajas
                               where c.NumCaja == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Aperturacaja>();
                }
                else
                {
                    var temp = from c in entities.Aperturacajas
                               where c.Nombre.Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Aperturacaja>();
                }


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

        public int EditarAperturasCajas(long id, Aperturacaja aperturacaja)
        {
            try
            {
                // Ojo
                // pendinte
                var p = entities.Aperturacajas.Find(id);
                Aperturacaja Nuevo = p;
                if (Nuevo != null)
                {
                    Nuevo.Fecha = aperturacaja.Fecha;
                    Nuevo.Observaciones = aperturacaja.Observaciones;
                    Nuevo.IdSucursal = aperturacaja.IdSucursal;
                    //Nuevo.AbonoApartadosdetalles = abono.AbonoApartadosdetalle;

                    entities.Entry(Nuevo).State = EntityState.Modified;

                    return entities.SaveChanges();
                }
                else
                {
                    return 0;// no se encotro el registro solicitado.
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
