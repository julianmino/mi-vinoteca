using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class DescuentoLogic : BusinessLogic
    {
        private int a = 1;

        public DescuentoLogic() { }

        public List<descuentos> GetAll()
        {
            List<descuentos> listaDescuentos = context.descuentos.ToList();

            return listaDescuentos;
        }
        public descuentos GetOne(int? id)
        {
            if (id != null)
            {
                return context.descuentos.SingleOrDefault(x => x.id_descuento == id);
            } else
            {
                return null;
            }
        }
        public descuentos GetByProducto(int id)
        {
            return context.descuentos.SingleOrDefault(x => x.id_producto == id);
        }
        public void Alta(DateTime fecha_caducidad, float porc, int id_producto)
        {
            try
            {
                var descuento = new descuentos()
                {
                    fecha_caducidad = fecha_caducidad,
                    porcentaje = porc,
                    id_producto = id_producto
                };
                context.descuentos.Add(descuento);
                context.Entry(descuento).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Modificacion(int id_descuento, DateTime fecha_caducidad, float porc, int id_producto)
        {
            try
            {
                descuentos descuento = this.GetOne(id_descuento);
                {
                    descuento.fecha_caducidad = fecha_caducidad;
                    descuento.porcentaje = porc;
                    descuento.id_producto = id_producto;
                };
                context.Entry(descuento).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }
        public void Baja(int id_descuento)
        {

            descuentos descuentoAEliminar = this.GetOne(id_descuento);
            if (descuentoAEliminar != null)
            {
                context.descuentos.Remove(descuentoAEliminar);
                context.SaveChanges();
            }
        }
    }
}
