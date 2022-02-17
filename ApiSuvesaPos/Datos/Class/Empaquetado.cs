using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Empaquetado
	{
		private SeePOSContext entities;

		public Empaquetado()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Empaquetado empaquetado) // registro de Empaquetado
		{
			try
			{
				entities.Empaquetados.Add(empaquetado);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Empaquetado> Buscar(bool porNombre, string filtro)  //consultar Empaquetado
		{
			try
			{
				List<Models.Empaquetado> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Empaquetados
							   select c;
					result = temp.ToList<Models.Empaquetado>();
				}
				else
				{
					var temp = from c in entities.Empaquetados
							   select c;
					result = temp.ToList<Models.Empaquetado>();
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

		public int Editar(long id, Models.Empaquetado nuevo) //editar Empaquetado
		{
			try
			{
				var p = entities.Empaquetados.Find(id);
				Models.Empaquetado viejo = p;
				if (viejo != null)
				{
					viejo.IdVentaDetalle = nuevo.IdVentaDetalle;
					viejo.Nombre = nuevo.Nombre;
					viejo.Cedula = nuevo.Cedula;
					viejo.Fecha = nuevo.Fecha;
					viejo.Timer = nuevo.Timer;
					viejo.Factura = nuevo.Factura;
					viejo.Tipo = nuevo.Tipo;

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

		public int Borrar(long id) //borrar Empaquetado
		{
			try
			{
				var p = entities.Empaquetados.Find(id);
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


