using Business.Logic;
using System;
using DAL;
using System.Net.Configuration;
using System.Web;

namespace WebApplication1 {
    public partial class userlogin : System.Web.UI.Page {
        readonly ClienteLogic cliLog = new ClienteLogic();
        protected void Page_Load(object sender, EventArgs e) {

            lblUsuario.Visible = false;
            lblContraseña.Visible = false;

            }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            _ = new cliente();
            try
            {
                cliente cli = cliLog.GetOne(txtUsuario.Text.Trim());
                if (cli != null)
                {
                    if (cli.clave == txtPassword.Text.Trim())
                    {
                        // Inicia sesion y redirige a homepage
                        Response.Write("<script language='javascript'>alert('Sesion iniciada correctamente')</script>");
                        Session["username"] = cli.usuario.ToString();
                        Session["name"] = cli.nombre.ToString();
                        Session["role"] = "cliente";
                        Session["status"] = cli.premium;
                        Response.Redirect("homepage.aspx");
                    }
                    else
                    {
                        // Mensaje de error contraseña incorrecta
                        lblContraseña.Visible = true;
                    }
                }
                else
                {
                    // Mensaje de usuario inexistente
                    lblUsuario.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
    }