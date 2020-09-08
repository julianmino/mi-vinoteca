using Business.Logic;
using System;
using DAL;
using System.Net.Configuration;

namespace WebApplication1 {
    public partial class userlogin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            ClienteLogic cliLog = new ClienteLogic();
            cliente cli = new cliente();
            cli = cliLog.GetByUser(txtUsuario.Text.Trim());
            

            if (cli != null) 
            {
                if (cli.clave == txtPassword.Text.Trim())
                {
                    //inicio sesion voy a homepage
                    Response.Write("<scrpit>alert('inicia sesion breo');</script>");
                    Session["username"] = cli.usuario.ToString();
                    Session["name"] = cli.nombre.ToString();
                    Session["role"] = "cliente";
                    Session["status"] = cli.premium;
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