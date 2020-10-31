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
        private LineaPedidoLogic lpLogic = new LineaPedidoLogic();
        private pedidos pedidoActual = new pedidos();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = pedLog.GetAll();
            dgvPedidos.DataBind();

            bool ban = Session.IsNewSession;
            Session["role"] = (ban) ? "" : Session["role"];
            try
            {

                if (Session["role"].Equals("admin"))
                {
                    if (Session["emailCliente"] != null)
                    {
                        pedidoActual = (pedidos)Session["pedido"];
                        llenarDatos(pedidoActual);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
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
                    guardarDatosSesion(pedidoActual);
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                    
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

            txtNombreYApellido.Text = Session["nombreCliente"].ToString();
            txtEmail.Text = Session["emailCliente"].ToString();
            txtObservaciones.Text = Session["observaciones"].ToString();
            txtFecha.Text = Session["fecha"].ToString();
            txtDescuento.Text = Session["idDescuento"].ToString();
            txtTotal.Text = Session["total"].ToString();
        }

        private void mostrarLineasPedido(pedidos pedido)
        {
            dgvProductos.DataSource = lpLogic.GetById_pedido(pedido.id_pedido);
            dgvProductos.DataBind();

        }

        private void guardarDatosSesion(pedidos pedido)
        {
            try
            {
                clientes cliente = cliLog.GetOne(pedido.usuario);

                Session["nombreCliente"] = cliente.nombre + " " + cliente.apellido;
                Session["emailCliente"] = cliente.email;
                Session["observaciones"] = pedido.observaciones;
                Session["fecha"] = pedido.fecha.ToString("dd/MM/yyyy");
                Session["idDescuento"] = pedido.id_descuento.ToString();
                Session["total"] = pedido.total.ToString();
                Session["pedidoActual"] = pedido;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}