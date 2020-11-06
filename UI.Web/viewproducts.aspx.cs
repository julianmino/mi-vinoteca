using Business.Logic;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class viewproducts : System.Web.UI.Page
    {
        ClienteLogic cliLogic = new ClienteLogic();
        clientes cliente = new clientes();

        LineaPedidoLogic lpLogic = new LineaPedidoLogic();
        lineas_pedidos lpActual = new lineas_pedidos();

        ProductoLogic prodLogic = new ProductoLogic();
        productos productoActual = new productos();

        private static List<lineas_pedidos> lp = new List<lineas_pedidos>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //para que se vean los botones de ir al carrito o no
            bool ban = Session.IsNewSession;
            if(Session["pedido"] != null)
            {
                lp = (List<lineas_pedidos>)Session["pedido"];
            } else
            {
                lp.Clear();
            }

            Session["role"] = (ban) ? "" : Session["role"];
            try
            {
                if (Session["role"].Equals(""))
                {
                    btnGoToCart.Visible = false;
                    BtnCancel.Visible = false;
                }
                else
                { 
                    if (ValidaEstadoCliente() && lp.Count > 0)
                    {
                        btnGoToCart.Visible = true;
                        BtnCancel.Visible = true;
                    }
                    else
                    {
                        btnGoToCart.Visible = false;
                        BtnCancel.Visible = false;
                    }
                }
                
            }
            catch
            {
                throw;
            }
        }
        

        

        //arreglo de indices para mantener los botones escondidos

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
                
                bool ban = Session.IsNewSession;
                Session["role"] = (ban) ? "" : Session["role"];
                if ((Session["role"].Equals("cliente")) || (Session["role"].Equals("admin")))
                {
                    if (ValidaEstadoCliente())
                    {
                        LinkButton button = (LinkButton)sender;
                        int id_prod = Convert.ToInt32(button.CommandArgument);

                        productoActual = prodLogic.GetOne(id_prod);

                        mapearDatosLineaPedido();

                        if (ProductoPuedeRegistrarse(lpActual))
                        {
                            lp.Add(lpActual);
                            Session["pedido"] = lp;
                            btnGoToCart.Visible = true;
                            BtnCancel.Visible = true;
                            //button.Visible = false;
                        } else
                        {
                            Response.Write("<script language='javascript'>alert('El producto ya se encuentra en el carrito.')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('El usuario no está habilitado para realizar pedidos')</script>");
                    }

                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Por favor inicie sesión o cree una cuenta para realizar pedidos')</script>");
                }
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
                
                lpActual.id_pedido = 0;
                lpActual.id_producto = productoActual.id_producto;
                lpActual.cantidad = 1;
                lpActual.subtotal = lpLogic.calculaSubtotal(productoActual,lpActual.cantidad);
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ProductoPuedeRegistrarse(lineas_pedidos linea_pedido)
        {
            bool ban = true;
            foreach (lineas_pedidos l in lp)
            {
                if(l.id_producto == linea_pedido.id_producto) 
                {
                    ban = false; 
                }
            }
            
            return ban;
        }

        private bool ValidaEstadoCliente()
        {
            bool ban = false;
            cliente = cliLogic.GetOne(Session["username"].ToString());
            if (cliente != null)
            {
                if (cliente.estado == "Habilitado") { ban = true; }
            }

            if (Session["role"].Equals("admin"))
            {
                ban = true;
            }
            return ban;
        }


        protected void Cancel_Click(object sender, EventArgs e)
        {
            lp.Clear();
            Session["pedido"] = lp;
            btnGoToCart.Visible = false;
            BtnCancel.Visible = false;
            Response.Write("<script language='javascript'>alert('Se borrarán los productos que se hayan añadido')</script>");

        }

        protected void btnGoToCart_Click1(object sender, EventArgs e)
        {
            Session["pedido"] = lp;
            Response.Redirect("shopping_cart.aspx");
        }
    }
}