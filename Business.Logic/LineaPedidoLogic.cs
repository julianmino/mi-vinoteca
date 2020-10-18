using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class LineaPedidoLogic:BusinessLogic
    {
        public LineaPedidoLogic() { }

        public List<lineas_pedidos> GetById_pedido(int id_pedido)
        {
            List<lineas_pedidos> lineas_pedidos = context.lineas_pedidos.Where(x => x.id_pedido == id_pedido).ToList();

            return lineas_pedidos;
        }
        public lineas_pedidos GetOne(int id_pedido, int id_producto)
        {
            return context.lineas_pedidos.SingleOrDefault(x => (x.id_pedido == id_pedido) && 
            (x.id_producto == id_producto));
        }
        public void Alta(int id_pedido, int id_producto, int cantidad, float subtotal)
        {
            try
            {
                var linea_pedido = new lineas_pedidos()
                {
                    id_pedido = id_pedido,
                    id_producto = id_producto,
                    cantidad = cantidad,
                    subtotal = subtotal
                };
                context.lineas_pedidos.Add(linea_pedido);
                context.Entry(linea_pedido).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public void Modificacion(int id_pedido, int id_producto, int cantidad, float subtotal)
        {
            try
            {
                lineas_pedidos linea_pedido = this.GetOne(id_pedido, id_producto);
                {
                    linea_pedido.id_pedido = id_pedido;
                    linea_pedido.id_producto = id_producto;
                    linea_pedido.cantidad = cantidad;
                    linea_pedido.subtotal = subtotal;
                };
                context.Entry(linea_pedido).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.InnerException?.Message);
            }
        }
        public void Baja(int id_pedido, int id_producto)
        {

            lineas_pedidos linea_pedidoAEliminar = this.GetOne(id_pedido, id_producto);
            if (linea_pedidoAEliminar != null)
            {
                context.lineas_pedidos.Remove(linea_pedidoAEliminar);
                context.SaveChanges();
            }
            

        }
    }
}
