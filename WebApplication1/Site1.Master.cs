using System;

namespace WebApplication1 {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) 
        {
            bool ban = Session.IsNewSession;
            Session["role"] = (ban)? "":Session["role"];
            try 
            {
                if (Session["role"].Equals(""))
                {
                    lbCerrarSesion.Visible = false;
                    lbHiThere.Visible = false;
                    lbIniciarSesion.Visible = true;
                    lbRegistrarse.Visible = true;

                    lbAdminLogin.Visible = true;
                    lbProducerManagement.Visible = false;
                    lbProductsManagement.Visible = false;
                    lbUserManagement.Visible = false;
                    lbPedidosManagement.Visible = false;
                }
                else if (Session["role"].Equals("cliente"))
                {
                    lbCerrarSesion.Visible = true;
                    lbHiThere.Visible = true;
                    lbIniciarSesion.Visible = false;
                    lbRegistrarse.Visible = false;

                    lbAdminLogin.Visible = false;
                    lbProducerManagement.Visible = false;
                    lbProductsManagement.Visible = false;
                    lbUserManagement.Visible = false;
                    lbPedidosManagement.Visible = false;

                    lbHiThere.Text = "Hola "+ Session["name"].ToString();
                }
                else if (Session["role"].Equals("admin"))
                {
                    //no se que hay en admin
                    lbCerrarSesion.Visible = true;
                    lbHiThere.Visible = true;
                    lbIniciarSesion.Visible = false;
                    lbRegistrarse.Visible = false;

                    lbAdminLogin.Visible = false;
                    lbProducerManagement.Visible = true;
                    lbProductsManagement.Visible = true;
                    lbUserManagement.Visible = true;
                    lbPedidosManagement.Visible = true;

                    lbHiThere.Text = "Admin, " + Session["name"].ToString();
                }
            }
            catch
            {

            }
        }

        protected void lbIniciarSesion_Click(object sender, EventArgs e) {
            Response.Redirect("userlogin.aspx");
            }

        protected void lbRegistrartse_Click(object sender, EventArgs e) {
            Response.Redirect("usersignup.aspx");
            }

        protected void lbVerProductos_Click(object sender, EventArgs e) {
            Response.Redirect("viewproducts.aspx");
            }

        protected void lbCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["name"] = "";
            Session["role"] = "";
            Session["status"] = "";

            Session["pedido"] = null;
            Session[""] = null;

            lbCerrarSesion.Visible = false;
            lbHiThere.Visible = false;
            lbIniciarSesion.Visible = true;
            lbRegistrarse.Visible = true;

            lbAdminLogin.Visible = true;
            
            Response.Redirect("homepage.aspx");
        }

        protected void lbUserManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_UsersManagement.aspx");
        }

        protected void lbProductsManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_ProductsManagement.aspx");
        }

        protected void lbProducerManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_ProducerManagement.aspx");
        }

        protected void lbPedidosManagement_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_PedidosManagement.aspx");
        }

        protected void lbAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }
    }
    }