using Business.Logic;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class viewproducts : System.Web.UI.Page
    {
        PedidoLogic pedidoLogic = new PedidoLogic();
        pedidos pedidoActual = new pedidos();

        LineaPedidoLogic lpLogic = new LineaPedidoLogic();
        lineas_pedidos lpActual = new lineas_pedidos();

        ProductoLogic prodLogic = new ProductoLogic();
        productos productoActual = new productos();

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["foto"]);
                (e.Row.FindControl("Image") as Image).ImageUrl = imageUrl;
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            try 
            {
                LinkButton button = (LinkButton)sender;
                int id_prod = Convert.ToInt32(button.CommandArgument);
                productoActual = prodLogic.GetOne(id_prod);
                
                pedidoActual = validaCreacionPedido();
                bool ban = false;

                if ( pedidoActual == null) 
                {
                    mapearDatosPedido();
                    ban = true;
                }
                mapearDatosLineaPedido();
                if (ValidaEstadoCliente())
                {
                    if (ProductoPuedeRegistrarse(pedidoActual, productoActual))
                    {
                        if (ban)
                        {
                            pedidoLogic.Alta(pedidoActual.usuario, pedidoActual.id_descuento, pedidoActual.fecha, pedidoActual.observaciones);
                        }

                        lpLogic.Alta(pedidoActual.id_pedido, productoActual.id_producto,1,productoActual.precio)
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private pedidos validaCreacionPedido()
        {
            pedidos pedido = new pedidos();
            pedido = null;
            List<pedidos> pedidosUsuario = new List<pedidos>();
            string usuario = Session["username"].ToString();
            pedidosUsuario = pedidoLogic.GetByUsuario(usuario);
            foreach (pedidos p in pedidosUsuario)
            {
                if (p.fecha == DateTime.Now)
                {
                    pedido = p;
                }
            }
            return pedido;
        }

        private void mapearDatosPedido()
        {
            try
            {

                pedidoActual.usuario = Session["username"].ToString();
                pedidoActual.id_descuento = null;
                pedidoActual.fecha = DateTime.Now;
                pedidoActual.observaciones = "";
                pedidoActual.total = 0;
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void mapearDatosLineaPedido()
        {
            try
            {
                
                lpActual.id_pedido = pedidoActual.id_pedido;
                lpActual.id_producto = productoActual.id_producto;
                lpActual.cantidad = 1;
                lpActual.subtotal = lpActual.cantidad * productoActual.precio;
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ProductoPuedeRegistrarse(pedidos pedido, productos producto)
        {
            bool ban = false;
            lineas_pedidos lp = new lineas_pedidos();
            lp = lpLogic.GetOne(pedido.id_pedido, producto.id_producto);
            if (lp == null) { ban = true; }
            return ban;
        }

        private bool ValidaEstadoCliente()
        {
            bool ban = false;
            ClienteLogic cliLogic = new ClienteLogic();
            clientes cliente = new clientes();
            cliente = cliLogic.GetOne(Session["username"].ToString());
            if (cliente.estado == "Activo") { ban = true; }
            return ban;
        }

       
    }
}