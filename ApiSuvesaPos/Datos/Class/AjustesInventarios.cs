﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Datos.Class
{
    public class AjustesInventarios
    {
        SeePOSContext entities;

        public AjustesInventarios()
        {
            entities = new SeePOSContext();
        }

        public int CrearAjustesInventarios(AjusteInventario aj)
        {
            try
            {
                entities.AjusteInventarios.Add(aj);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int BorrarAjusteInventario(int id)


        {
            try
            {
                var p = entities.AjusteInventarios.Find(id);
                entities.Remove(p);
                return entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<AjusteInventario> ObtenerAjusteInventario()
        {
            try
            {
                var temp = from c in entities.AjusteInventarios

                           select c;
                List<AjusteInventario> result = temp.ToList<AjusteInventario>();

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

        public List<AjusteInventario> ObtenerAjusteInventario(int id)
        {
            try
            {
                var temp = from c in entities.AjusteInventarios
                           where c.Consecutivo == id
                           select c;
                List<AjusteInventario> result = temp.ToList<AjusteInventario>();

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

        public int EditarAjusteInventario(int id, AjusteInventario abono)
        {
            try
            {
                var p = entities.AjusteInventarios.Find(id);
                AjusteInventario Nuevo = p;
                
                Nuevo.Fecha = abono.Fecha;
                
                Nuevo.Anula = abono.Anula;
                
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