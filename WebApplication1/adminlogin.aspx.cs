using Business.Logic;
using DAL;
using System;

namespace WebApplication1 {
    public partial class adminlogin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            AdminLogic adminLog = new AdminLogic();
            admin admin = new admin();
            admin = adminLog.GetByUser(txtUsuario.Text.Trim());
            

            if (admin != null)
            {
                if (admin.clave == txtPassword.Text.Trim())
                {
                    //inicio sesion voy a homepage
                    //Server.Transfer("homepage.aspx");
                    Response.Write("<scrpit>alert('inicia sesion breo');</script>");
                    Session["username"] = admin.usuario.ToString();
                    Session["name"] = admin.nombre.ToString();
                    Session["role"] = "admin";
                    Session["status"] = "";
                    Response.Redirect("homepage.aspx");

                }
                else
                {
                    //mensaje de error contrasenia incorrecta
                    Response.Write("<scrpit>alert('contraseña incorrecta');</script>");
                }
            }
            else
            {
                //mensaje de usuario inexistente
                Response.Write("<scrpit>alert('usuario inexistente');</script>");
            }
        }
    }
}