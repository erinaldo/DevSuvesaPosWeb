using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
   public  class AbonosPagar
    {
        SeePOSContext entities;

        public AbonosPagar()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoPagar(Abonocpagar Abono)
        {
            try
            {
                entities.Abonocpagars.Add(Abono);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAbonoPagar(int id)


        {
            try
            {
                var p = entities.Abonocpagars.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Abonocpagar> ObtenerAbonoApartado()
        {
            try
            {
                var temp = from c in entities.Abonocpagars

                           select c;
                List<Abonocpagar> result = temp.ToList<Abonocpagar>();

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

        public List<Abonocpagar> ObtenerAbonoApartado(int id)
        {
            try
            {
                var temp = from c in entities.Abonocpagars
                           where c.IdAbonocpagar == id
                           select c;
                List<Abonocpagar> result = temp.ToList<Abonocpagar>();

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

        public int EditarAbonoPagar(int id, Abonocpagar abono)
        {
            try
            {
                var p = entities.AbonoApartados.Find(id);
                Abonocpagar Nuevo = p;
              
                Nuevo.SaldoCuenta = abono.SaldoCuenta;
                Nuevo.Monto = abono.Monto;
                Nuevo.SaldoActual = abono.SaldoActual;
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
