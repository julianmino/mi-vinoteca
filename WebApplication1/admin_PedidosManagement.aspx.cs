using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Business.Logic;

namespace WebApplication1
{
    public partial class admin_PedidosManagement : System.Web.UI.Page
    {
        private PedidoLogic pedLog = new PedidoLogic();
        private ClienteLogic cliLog = new ClienteLogic();
        private pedidos pedidoActual = new pedidos();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pedLog.GetAll();
            dgvPedidos.DataBind();
        }

        protected void onCheckedPressed(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtUsuario.Text))
                {
                    //pedidoActual = pedLog.GetByUsuario(txtUsuario.Text);
                } else
                {
                    pedidoActual = pedLog.GetOne(Int32.Parse(txtIdPedido.Text));
                }

                if (pedidoActual != null)
                {
                    llenarDatos(pedidoActual);
                    //Falta el DataSource y DataBind del dgvProductos aca.
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void onCancelarPressed(object sender, EventArgs e)
        {

        }

        protected void onFinalizarPressed(object sender, EventArgs e)
        {

        }

        private void llenarDatos(pedidos pedido)
        {
            clientes cliente = cliLog.GetOne(pedido.usuario);

            txtNombreYApellido.Text = cliente.nombre + " " + cliente.apellido;
            txtEmail.Text = cliente.email;
            txtObservaciones.Text = pedido.observaciones;
            txtFecha.Text = pedido.fecha.ToString("dd/MM/yyyy");
            txtDescuento.Text = pedido.id_descuento.ToString();
            txtTotal.Text = pedido.total.ToString();
        }
    }
}