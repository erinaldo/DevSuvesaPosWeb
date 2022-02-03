using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Familia
	{
		private SeePOSContext entities;

		public Familia()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Familium familia) // registro de Familia
		{
			try
			{
				entities.Familia.Add(familia);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Familium> Buscar(bool porNombre, string filtro)  //consultar Familia
		{
			try
			{
				List<Models.Familium> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Familia
							   select c;
					result = temp.ToList<Models.Familium>();
				}
				else
				{
					var temp = from c in entities.Familia
							   select c;
					result = temp.ToList<Models.Familium>();
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

		public int Editar(long id, Models.Familium nuevo) //editar Familia
		{
			try
			{
				var p = entities.Familia.Find(id);
				Models.Familium viejo = p;
				if (viejo != null)
				{
					viejo.Codigo = nuevo.Codigo;
					viejo.Descripcion = nuevo.Descripcion;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.CuentaGra = nuevo.CuentaGra;
					viejo.DescripcionGra = nuevo.DescripcionGra;
					viejo.CuentaExe = nuevo.CuentaExe;
					viejo.DescripcionExe = nuevo.DescripcionExe;
					viejo.CuentaCosto = nuevo.CuentaCosto;
					viejo.DescripcionCosto = nuevo.DescripcionCosto;

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

		public int Borrar(long id) //borrar Familia
		{
			try
			{
				var p = entities.Familia.Find(id);
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


