using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosFE.Models;

namespace DatosFE.Class
{
    public class Vistas
    {
        private FEContext entities;

        public Vistas()
        {
            entities = new FEContext();
        }

        public List<ViewFactura> ObtenerFacturas() //obtener lista actividades 
        {
            try
            {
                var temp = from c in entities.ViewFacturas

                           select c;
                List<ViewFactura> result = temp.ToList<ViewFactura>();

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


    }
}
