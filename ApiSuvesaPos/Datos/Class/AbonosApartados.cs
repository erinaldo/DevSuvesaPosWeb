using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AbonosApartados
    {
        SeePOSContext entities;

        public AbonosApartados()
        {
            entities = new SeePOSContext();
        }

        public int CrearAbonoApartado(AbonoApartado Abono)
        {
            try
            {
                entities.AbonoApartados.Add(Abono);
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
                var p = entities.AbonoApartados.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AbonoApartado> ObtenerAbonoApartado()  
        {
            try
            {
                var temp = from c in entities.AbonoApartados

                           select c;
                List<AbonoApartado> result = temp.ToList<AbonoApartado>();

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

        public List<AbonoApartado> ObtenerAbonoApartado(int id)  
        {
            try
            {
                var temp = from c in entities.AbonoApartados
                           where c.IdAbonoapartado == id
                           select c;
                List<AbonoApartado> result = temp.ToList<AbonoApartado>();

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

        public int EditarEstadoYConcecutivoMensajeReceptor(int id, AbonoApartado abono) 
        {
            try
            {
                var p = entities.AbonoApartados.Find(id);
                AbonoApartado Nuevo = p;
                Nuevo.CodCliente = abono.CodCliente;
                Nuevo.NombreCliente = abono.NombreCliente;
                Nuevo.SaldoCuenta = abono.SaldoCuenta;
                Nuevo.Monto = abono.Monto;
                Nuevo.SaldoActual = abono.SaldoActual;
                Nuevo.Fecha = abono.Fecha;
                Nuevo.Observaciones = abono.Observaciones;
                Nuevo.Anula = abono.Anula;
                Nuevo.CedUsuario = abono.CedUsuario;
                Nuevo.CodMoneda = abono.CodMoneda;
                Nuevo.NumRecibo = abono.NumRecibo;
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
