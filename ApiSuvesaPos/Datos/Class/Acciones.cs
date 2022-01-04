using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class Acciones
    {
        SeePOSContext entities;

        public Acciones()
        {
            entities = new SeePOSContext();
        }

        public int CrearAcciones(Accion acc)
        {
            try
            {
                entities.AbonoApartados.Add(acc);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAcciones(int id)


        {
            try
            {
                var p = entities.Accions.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Accion> ObtenerAcciones()
        {
            try
            {
                var temp = from c in entities.Accions

                           select c;
                List<Accion> result = temp.ToList<Accion>();

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

        public List<Accion> ObtenerAcciones(int id)
        {
            try
            {
                var temp = from c in entities.Accions
                           where c.Id == id
                           select c;
                List<Accion> result = temp.ToList<Accion>();

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

        public int EditarAcciones(int id, Accion abono)
        {
            try
            {
                var p = entities.AbonoApartados.Find(id);
                Accion Nuevo = p;
                
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
