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
        
        private enum Acciones
        {
            Finalizar,
            Borrar
        }
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
                        if(Session["pedidoActual"] != null)
                        {
                            pedidoActual = (pedidos)Session["pedidoActual"];
                            llenarDatos(pedidoActual);
                            dgvProductos.DataSource = lpLogic.GetById_pedido(pedidoActual.id_pedido);
                            dgvProductos.DataBind();
                        } else
                        {
                            dgvProductos.DataSource = null;
                            dgvProductos.DataBind();
                        }
                        
                    }
                } else
                {
                    Response.Redirect("homepage.aspx");
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
                pedidoActual = pedLog.GetOne(Int32.Parse(txtIdPedido.Text));

                if (pedidoActual != null)
                {
                    guardarDatosSesion(pedidoActual);
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void onBorrarPressed(object sender, EventArgs e)
        {
            try
            {
                realizarBaja(Acciones.Borrar);
                //falta corregir el stock de los productos en cada linea
            } catch (Exception)
            {
                throw;
            }
        }

        protected void onFinalizarPressed(object sender, EventArgs e)
        {
            try
            {
                clientes cliente = cliLog.GetOne(pedidoActual.usuario);
                cliente.pedidos.Add(pedidoActual);
                realizarBaja(Acciones.Finalizar);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void realizarBaja(Enum accion)
        {
            if (pedidoActual != null)
            {
                try
                {
                    foreach (lineas_pedidos lp in pedidoActual.lineas_pedidos)
                    {
                        lpLogic.Baja(lp.id_pedido, lp.id_producto);
                    }
                    pedLog.Baja(pedidoActual.id_pedido);
                    limpiarDatosSesion();
                    limpiarDatos();
                    switch (accion)
                    {
                        case Acciones.Borrar:
                            Response.Write("<script language='javascript'>alert('El pedido ha sido borrado exitosamente.')</script>");
                            break;
                        case Acciones.Finalizar:
                            Response.Write("<script language='javascript'>alert('El pedido ha sido guardado en el histórico de pedidos del usuario exitosamente.')</script>");
                            break;
                    }
                    Page.Response.Redirect(Page.Request.Url.ToString(), false);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void llenarDatos(pedidos pedido)
        {
            clientes cliente = cliLog.GetOne(pedido.usuario);

            txtIdPedido.Text = Session["id_pedido"].ToString();
            txtNombreYApellido.Text = Session["nombreCliente"].ToString();
            txtEmail.Text = Session["emailCliente"].ToString();
            txtObservaciones.Text = Session["observaciones"].ToString();
            txtFecha.Text = Session["fecha"].ToString();
            txtDescuento.Text = Session["idDescuento"].ToString();
            txtTotal.Text = Session["total"].ToString();
        }

        private void limpiarDatos()
        {
            txtNombreYApellido.Text = "";
            txtEmail.Text = "";
            txtObservaciones.Text = "";
            txtFecha.Text = "";
            txtDescuento.Text = "";
            txtTotal.Text = "";
        }


        private void guardarDatosSesion(pedidos pedido)
        {
            try
            {
                clientes cliente = cliLog.GetOne(pedido.usuario);

                Session["id_pedido"] = pedido.id_pedido;
                Session["nombreCliente"] = cliente.nombre + " " + cliente.apellido;
                Session["emailCliente"] = cliente.email;
                Session["observaciones"] = (String.IsNullOrEmpty(pedido.observaciones)) ? "-" : pedido.observaciones;
                Session["fecha"] = pedido.fecha.ToString("dd/MM/yyyy");
                Session["idDescuento"] = (String.IsNullOrEmpty(pedido.id_descuento.ToString())) ? "-" : pedido.id_descuento.ToString();
                Session["total"] = pedido.total.ToString();
                Session["pedidoActual"] = pedido;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void limpiarDatosSesion()
        {
            Session["id_pedido"] = null;
            Session["nombreCliente"] = null;
            Session["emailCliente"] = null;
            Session["observaciones"] = null;
            Session["fecha"] = null;
            Session["idDescuento"] = null;
            Session["total"] = null;
            Session["pedidoActual"] = null;
        }
    }
}