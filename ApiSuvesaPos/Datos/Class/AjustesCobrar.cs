using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AjustesCobrar
    {
        SeePOSContext entities;

        public AjustesCobrar()
        {
            entities = new SeePOSContext();
        }

        public int CrearAjusteCobro(Ajustesccobrar Abono)
        {
            try
            {
                entities.Ajustesccobrars.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAjusteCobro(int id)


        {
            try
            {
                var p = entities.Ajustesccobrars.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Ajustesccobrar> ObtenerAjusteCobro(bool porId, string Filtro)
        {
            try
            {
                List<Ajustesccobrar> result;

                if (porId == true)
                {
                    var temp = from c in entities.Ajustesccobrars
                               where c.IdAjuste == Convert.ToInt64(Filtro)
                               select c;
                    result = temp.ToList<Ajustesccobrar>();
                }
                else
                {
                    var temp = from c in entities.Ajustesccobrars
                               where c.NombreCliente.Contains(Filtro) || c.AjusteNo.ToString().Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Ajustesccobrar>();
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

        public List<Ajustesccobrar> ObtenerAjusteCobro(int id)
        {
            try
            {
                var temp = from c in entities.Ajustesccobrars
                           where c.IdAjuste == id
                           select c;
                List<Ajustesccobrar> result = temp.ToList<Ajustesccobrar>();

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

        public int AnularAjusteCobro(long id)
        {
            try
            {
                var p = entities.Ajustesccobrars.Find(id);
                Ajustesccobrar Nuevo = p;
                Nuevo.Anula = true;
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
