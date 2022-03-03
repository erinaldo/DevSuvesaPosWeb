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
					var temp = from fam in entities.Familia
							   join subFam in entities.SubFamilias on fam.Codigo equals subFam.CodigoFamilia
							   where fam.Descripcion.Contains(filtro)
							   select new Models.Familium  { 
								   Codigo = fam.Codigo, 
								   Descripcion = fam.Descripcion,  
								   Observaciones =  fam.Observaciones, 
								   CuentaGra = fam.CuentaGra, 
								   DescripcionGra = fam.DescripcionGra, 
								   CuentaExe = fam.CuentaExe, 
								   DescripcionExe = fam.DescripcionExe, 
								   CuentaCosto = fam.CuentaCosto, 
								   DescripcionCosto = fam.DescripcionCosto,
								   SubFamilia = null
							   };
					result = temp.ToList<Models.Familium>();
				}
				else
				{
					var temp = from c in entities.Familia
							   where c.Codigo == Convert.ToInt32(filtro)
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
				Models.Familium Nuevo = p;
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


