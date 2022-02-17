using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
	public class Modulos
	{
		private SeePOSContext entities;

		public Modulos()
		{
			entities = new SeePOSContext();
		}

		public int Crear(Models.Modulos modulos) // registro de Modulos
		{
			try
			{
				entities.Modulos.Add(modulos);
				return entities.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public List<Models.Modulos> Buscar(bool porNombre, string filtro)  //consultar Modulos
		{
			try
			{
				List<Models.Modulos> result;
				if (porNombre == true)
				{
					var temp = from c in entities.Modulos							   
							   select c;
					result = temp.ToList<Models.Modulos>();
				}
				else
				{
					var temp = from c in entities.Modulos
							   select c;
					result = temp.ToList<Models.Modulos>();
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

		public int Editar(long id, Models.Modulos nuevo) //editar Modulos
		{
			try
			{
				var p = entities.Modulos.Find(id);
				Models.Modulos viejo = p;
				if (viejo != null)
				{
					viejo.Idmodulo = nuevo.Idmodulo;
					viejo.ModuloNombreInterno = nuevo.ModuloNombreInterno;
					viejo.ModuloNombre = nuevo.ModuloNombre;
					viejo.Software = nuevo.Software;
					viejo.Grupo = nuevo.Grupo;

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

		public int Borrar(long id) //borrar Modulos
		{
			try
			{
				var p = entities.Modulos.Find(id);
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


