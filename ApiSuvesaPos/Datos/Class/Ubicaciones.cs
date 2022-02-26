using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Ubicaciones
	{
		private SeePOSContext entities;

		public Ubicaciones()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Ubicacione ubicaciones) // registro de Ubicaciones
		{
			try
			{
				entities.Ubicaciones.Add(ubicaciones);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Ubicacione> Buscar(bool porNombre, string filtro)  //consultar Ubicaciones
		{
			try
			{
				List<Models.Ubicacione> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Ubicaciones
							   where c.Descripcion.Contains(filtro) 
							   select c;
					result = temp.ToList<Models.Ubicacione>();
				}
				else
				{
					var temp = from c in entities.Ubicaciones
							   where c.Codigo == Convert.ToInt32(filtro)
							   select c;
					result = temp.ToList<Models.Ubicacione>();
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

		public int Editar(long id, Models.Ubicacione nuevo) //editar Ubicaciones
		{
			try
			{
				var p = entities.Ubicaciones.Find(id);
				Models.Ubicacione viejo = p;
				if (viejo != null)
				{
					viejo.Codigo = nuevo.Codigo;
					viejo.Descripcion = nuevo.Descripcion;
					viejo.Observaciones = nuevo.Observaciones;
					viejo.Activa = nuevo.Activa;

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

		public int Borrar(long id) //borrar Ubicaciones
		{
			try
			{
				var p = entities.Ubicaciones.Find(id);
				Models.Ubicacione Nuevo = p;
				if (Nuevo != null)
				{
					entities.Remove(p);
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


