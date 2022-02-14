using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class OrdenCompra
	{
		private SeePOSContext entities;

		public OrdenCompra()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Ordencompra ordencompra) // registro de OrdenCompra
		{
			try
			{
				entities.Ordencompras.Add(ordencompra);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Ordencompra> Buscar(bool porNombre, string filtro)  //consultar OrdenCompra
		{
			try
			{
				List<Models.Ordencompra> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Ordencompras
							   where c.Nombre.Contains(filtro)
							   orderby c.Fecha descending
							   select c;
					result = temp.ToList<Models.Ordencompra>();
				}
				else
				{
					var temp = from c in entities.Ordencompras
							   where c.Orden == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Ordencompra>();
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

		public int Editar(long id, Models.Ordencompra nuevo) //editar OrdenCompra
		{
			try
			{
				var p = entities.Ordencompras.Find(id);
				Models.Ordencompra viejo = p;
				if (viejo != null)
				{					
					viejo.Proveedor = nuevo.Proveedor;
					viejo.Nombre = nuevo.Nombre;
					viejo.Fecha = nuevo.Fecha;
					viejo.Contado = nuevo.Contado;
					viejo.Credito = nuevo.Credito;
					viejo.Diascredito = nuevo.Diascredito;
					viejo.Plazo = nuevo.Plazo;
					viejo.Descuento = nuevo.Descuento;
					viejo.Impuesto = nuevo.Impuesto;
					viejo.Total = nuevo.Total;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.Usuario = nuevo.Usuario;
					viejo.NombreUsuario = nuevo.NombreUsuario;
					viejo.Entregar = nuevo.Entregar;
					viejo.CodMoneda = nuevo.CodMoneda;
					viejo.SubTotalGravado = nuevo.SubTotalGravado;
					viejo.SubTotalExento = nuevo.SubTotalExento;
					viejo.SubTotal = nuevo.SubTotal;
					viejo.Anulado = nuevo.Anulado;

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

		public int Anular(long id) //anular OrdenCompra
		{
			try
			{
				var p = entities.Ordencompras.Find(id);
				Models.Ordencompra viejo = p;
				if (viejo != null)
				{
					viejo.Anulado = true;
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

	}
}


