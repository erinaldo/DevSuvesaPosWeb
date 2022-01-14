using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AbonosCobros
    {
        SeePOSContext entities;

        public AbonosCobros()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoCobro(Abonoccobrar Abono)
        {
            try
            {
                entities.Abonoccobrars.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoCobro(int id)


        {
            try
            {
                var p = entities.Abonoccobrars.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Abonoccobrar> ObtenerAbonoCobros()
        {
            try
            {
                var temp = from c in entities.Abonoccobrars

                           select c;
                List<Abonoccobrar> result = temp.ToList<Abonoccobrar>();

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

        public List<Abonoccobrar> ObtenerAbonocCobrar(bool porIdRecibo, string Filtro)// id recibo
        {
            try
            {
                List<Abonoccobrar> result;

                if (porIdRecibo == true)
                {
                    var temp = from c in entities.Abonoccobrars
                               where c.IdRecibo == Convert.ToInt64(Filtro)                               
                               select c;
                    result = temp.ToList<Abonoccobrar>();
                }
                else
                {
                    var temp = from c in entities.Abonoccobrars
                               where c.NombreCliente.Contains(Filtro) || c.NumRecibo.ToString().Contains(Filtro)
                               orderby c.Fecha descending
                               select c;
                    result = temp.ToList<Abonoccobrar>();
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

        public int EditarAbonoscobros(long id)
        {
            try
            {
                var p = entities.Abonoccobrars.Find(id);
                Abonoccobrar Nuevo = p;
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
