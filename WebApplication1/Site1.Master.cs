using System;

namespace WebApplication1 {
    public partial class Site1 : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) 
        {
            try 
            {
                if (Session["role"].Equals(""))
                {
                    lbCerrarSesion.Visible = false;
                    lbHiThere.Visible = false;
                    lbIniciarSesion.Visible = true;
                    lbRegistrarse.Visible = true;

                    lbAdminLogin.Visible = true;
                }
                else if (Session["role"].Equals("cliente"))
                {
                    lbCerrarSesion.Visible = true;
                    lbHiThere.Visible = true;
                    lbIniciarSesion.Visible = false;
                    lbRegistrarse.Visible = false;

                    lbAdminLogin.Visible = false;

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

            lbCerrarSesion.Visible = false;
            lbHiThere.Visible = false;
            lbIniciarSesion.Visible = true;
            lbRegistrarse.Visible = true;

            lbAdminLogin.Visible = true;
        }
    }
    }