using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic
{
    public class ProductorLogic : BusinessLogic
    {
        public ProductorLogic()
        {
        }

        public List<productores> GetAll()
        {
            List<productores> listaProductores = context.productores.ToList();

            return listaProductores;
        }

        public productores GetOne(int id_productor)
        {

            return context.productores.SingleOrDefault(x => x.id_productor == id_productor);
        }


        public void Alta(string nombre)
        {
            try
            {
                var productor = new productores()
                {
                    nombre = nombre
                };
                context.productores.Add(productor);
                context.Entry(productor).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Modificacion(int id_productor, string nombre)
        {
            try
            {
                productores productor = this.GetOne(id_productor);
                {
                    productor.id_productor = id_productor;
                    productor.nombre = nombre;
                };

                context.Entry(productor).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }

        public void Baja(int id_productor)
        {

            productores productorAEliminar = this.GetOne(id_productor);
            if (productorAEliminar != null)
            {
                context.productores.Remove(productorAEliminar);
                context.Entry(productorAEliminar).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }

        }

        public productores GetProductorDeNombre(string nombre)
        {
            productores productor = context.productores.Where(x => x.nombre == nombre).SingleOrDefault();
            return productor;
        }
    }
}
