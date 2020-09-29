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
                    // Inicia sesion y redirige a homepage
                    //Server.Transfer("homepage.aspx");
                    Response.Write("<scrpit language='javascript'>alert('inicia sesion breo');</script>");
                    Session["username"] = admin.usuario.ToString();
                    Session["name"] = admin.nombre.ToString();
                    Session["role"] = "admin";
                    Session["status"] = "";
                    Response.Redirect("admin-UsersManagement.aspx");
                }
                else
                {
                    // Mensaje de error contraseña incorrecta
                    Response.Write("<scrpit language='javascript'>alert('contraseña incorrecta');</script>");
                }
            }
            else
            {
                // Mensaje de usuario inexistente
                Response.Write("<scrpit language='javascript'>alert('usuario inexistente');</script>");
            }
        }
    }
}