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

        public int AnuarArqueosCajas(int id)


        {
            try
            {
                var p = entities.ArqueoCajas.Find(id);
                ArqueoCaja Nuevo = p;
                Nuevo.Anulado = true;

                entities.Entry(Nuevo).State = EntityState.Modified;

                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ArqueoCaja> ObtenerArqueosCajas(bool porId, string Filtro)
        {
            try
            {
                List<ArqueoCaja> result;

                if (porId == true)
                {
                    var temp = from c in entities.ArqueoCajas
                               where c.Id == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<ArqueoCaja>();
                }
                else
                {
                    // Ojo tomar en cuenta el estado de la caja.
                    // puede que quiera todos los arqueos o que solo quiera los que estan sin cerrar.
                    var temp = from c in entities.ArqueoCajas
                               join a in entities.Aperturacajas on c.IdApertura equals a.Napertura
                               where a.Nombre.Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<ArqueoCaja>();
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


        public int EditarArqueosCajas(int id, ArqueoCaja abono)
        {
            try
            {


                // Ojo
                // pendinte
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
