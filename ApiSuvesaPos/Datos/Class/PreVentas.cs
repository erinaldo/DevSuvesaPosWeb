using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class PreVentas
	{
		private SeePOSContext entities;

		public PreVentas()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.PreVenta preventas) // registro de PreVentas
		{
			try
			{
				entities.PreVentas.Add(preventas);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.PreVentasDetalle> BuscarDetalle(long Id)  //consultar PreVentas
		{
			try
			{
				List<Models.PreVentasDetalle> result;
				
					var temp = from c in entities.PreVentasDetalles
							   where c.IdFactura == Id
							   select c;
					result = temp.ToList<Models.PreVentasDetalle>();
				
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

		public Models.PreVenta Obtener(long id)  //consultar PreVentas
		{
			var p = entities.PreVentas.Find(id);
			Models.PreVenta viejo = p;
			if (viejo != null)
			{
				return viejo;
			}
			else
			{
				return null;
			}
		}

		public List<Models.ViewPreventasActiva> FichasActivas()  //consultar PreVentas Activas
		{
			try
			{
				List<Models.ViewPreventasActiva> result;
				
					var temp = from c in entities.ViewPreventasActivas							   
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.ViewPreventasActiva>();
				
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

		public List<Models.PreVenta> Buscar(bool porNombre, string filtro)  //consultar PreVentas
		{
			try
			{
				List<Models.PreVenta> result;
				if (porNombre == true)
				{
					var temp = from c in entities.PreVentas
							   where c.NombreCliente.Contains(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.PreVenta>();
				}
				else
				{
					var temp = from c in entities.PreVentas
							   where c.NumFactura == Convert.ToInt32(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.PreVenta>();
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

		public int Editar(long id, Models.PreVenta nuevo) //editar PreVentas
		{
			try
			{
				var p = entities.PreVentas.Find(id);
				Models.PreVenta viejo = p;
				if (viejo != null)
				{
					viejo.Id = nuevo.Id;
					viejo.NumFactura = nuevo.NumFactura;
					viejo.Tipo = nuevo.Tipo;
					viejo.CodCliente = nuevo.CodCliente;
					viejo.NombreCliente = nuevo.NombreCliente;
					viejo.Orden = nuevo.Orden;
					viejo.CedulaUsuario = nuevo.CedulaUsuario;
					viejo.PagoComision = nuevo.PagoComision;
					viejo.SubTotal = nuevo.SubTotal;
					viejo.Descuento = nuevo.Descuento;
					viejo.ImpVenta = nuevo.ImpVenta;
					viejo.Total = nuevo.Total;
					viejo.Fecha = nuevo.Fecha;
					viejo.Vence = nuevo.Vence;
					viejo.CodEncargadoCompra = nuevo.CodEncargadoCompra;
					viejo.Contabilizado = nuevo.Contabilizado;
					viejo.AsientoVenta = nuevo.AsientoVenta;
					viejo.ContabilizadoCventa = nuevo.ContabilizadoCventa;
					viejo.AsientoCosto = nuevo.AsientoCosto;
					viejo.Anulado = nuevo.Anulado;
					viejo.PagoImpuesto = nuevo.PagoImpuesto;
					viejo.FacturaCancelado = nuevo.FacturaCancelado;
					viejo.NumApertura = nuevo.NumApertura;
					viejo.Entregado = nuevo.Entregado;
					viejo.CodMoneda = nuevo.CodMoneda;
					viejo.MonedaNombre = nuevo.MonedaNombre;
					viejo.Direccion = nuevo.Direccion;
					viejo.Telefono = nuevo.Telefono;
					viejo.SubTotalGravada = nuevo.SubTotalGravada;
					viejo.SubTotalExento = nuevo.SubTotalExento;
					viejo.Transporte = nuevo.Transporte;
					viejo.TipoCambio = nuevo.TipoCambio;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.Exonerar = nuevo.Exonerar;
					viejo.Taller = nuevo.Taller;
					viejo.Mascotas = nuevo.Mascotas;
					viejo.NumCaja = nuevo.NumCaja;
					viejo.Agente = nuevo.Agente;
					viejo.CodAgente = nuevo.CodAgente;
					viejo.Apartado = nuevo.Apartado;
					viejo.EnviadoMh = nuevo.EnviadoMh;
					viejo.Cedula = nuevo.Cedula;
					viejo.ClaveMh = nuevo.ClaveMh;
					viejo.EstadoMh = nuevo.EstadoMh;
					viejo.TipoCedula = nuevo.TipoCedula;
					viejo.ConsecutivoMh = nuevo.ConsecutivoMh;
					viejo.ExcluirCxC = nuevo.ExcluirCxC;
					viejo.Ficha = nuevo.Ficha;
					viejo.Estado = nuevo.Estado;
					viejo.IdCotizacion = nuevo.IdCotizacion;
					viejo.Frecuente = nuevo.Frecuente;
					viejo.IdFactura = nuevo.IdFactura;
					viejo.IdFacturaRemplaza = nuevo.IdFacturaRemplaza;

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

		public int Borrar(long id) //borrar PreVentas
		{
			try
			{
				var p = entities.PreVentas.Find(id);
				entities.Remove(p);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}


