using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;


namespace Datos.Class
{
 public   class Cotizacion
    {

        private SeePOSContext entities;

        public Cotizacion()
        {
            entities = new SeePOSContext();
        }

        public int Crear(Models.Cotizacion cotizacion) // crear carta apartir de objeto de creacion
        {
            try
            {
                entities.Cotizacions.Add(cotizacion);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Models.Cotizacion> Buscar(bool porNombre, string filtro) //obtener lista CartasdeExoneracion 
        {
            try
            {
                List<Models.Cotizacion> result;

                if (porNombre == true)
                {
                    //busca por la descripcion
                    var temp = from c in entities.Cotizacions
                               where c.NombreCliente.Contains(filtro) // usar un like
                               orderby c.Fecha descending
                               select c;

                    result = temp.ToList<Models.Cotizacion>();
                }
                else
                {
                    //busca por el id de la tabla
                    var temp = from c in entities.Cotizacions
                               where c.Cotizacion1 == Convert.ToInt64(filtro) //convertir el datos de string a long
                               select c;
                    result = temp.ToList<Models.Cotizacion>();
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

        public int Editar(long id, Models.Cotizacion nuevo)
        {
            try
            {
                var p = entities.Cotizacions.Find(id);
                Models.Cotizacion viejo = p;

                if (viejo != null)
                {
                    viejo.Fecha = nuevo.Fecha;
                    viejo.CodCliente = nuevo.CodCliente;
                    viejo.NombreCliente = nuevo.NombreCliente;
                    viejo.Contacto = nuevo.Contacto;
                    viejo.Validez = nuevo.Validez;
                    viejo.TiempoEntrega = nuevo.TiempoEntrega;
                    viejo.Contado = nuevo.Contado;
                    viejo.Credito = nuevo.Credito;
                    viejo.Anulado = nuevo.Anulado;
                    viejo.Dias = nuevo.Dias;
                    viejo.Observaciones = nuevo.Observaciones;
                    viejo.SubTotalGravada = nuevo.SubTotalGravada;
                    viejo.SubTotalExento = nuevo.SubTotalExento;
                    viejo.Descuento = nuevo.Descuento;
                    viejo.PagoImpuesto = nuevo.PagoImpuesto;
                    viejo.Total = nuevo.Total;
                    viejo.Cedula = nuevo.Cedula;
                    viejo.CodMoneda = nuevo.CodMoneda;
                    viejo.MonedaNombre = nuevo.MonedaNombre;
                    viejo.SubTotal = nuevo.SubTotal;
                    viejo.TipoCambio = nuevo.TipoCambio;
                    viejo.ImpVenta = nuevo.ImpVenta;
                    viejo.Transporte = nuevo.Transporte;
                    viejo.Venta = nuevo.Venta;
                    viejo.Exonerar = nuevo.Exonerar;
                    viejo.Confirmada = nuevo.Confirmada;
                    viejo.ConfirmadaPor = nuevo.ConfirmadaPor;
                    viejo.EstadoActual = nuevo.EstadoActual;
                    viejo.ObservacionEstado = nuevo.ObservacionEstado;
                    viejo.Telefono = nuevo.Telefono;
                    viejo.TipoCedula = nuevo.TipoCedula;
                    viejo.CedulaCliente = nuevo.CedulaCliente;

                    //agregar detalle
                    entities.Entry(viejo).State = EntityState.Modified;

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

        public int Anular(long id)
        {
            try
            {
                var p = entities.Cotizacions.Find(id);
                Models.Cotizacion cotizacion = p;

                if (cotizacion != null)
                {

                    cotizacion.Anulado = true;
                    entities.Entry(cotizacion).State = EntityState.Modified;

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
