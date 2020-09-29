using Business.Logic;
using System;
using DAL;
using System.Net.Configuration;
using System.Web;

namespace WebApplication1 {
    public partial class userlogin : System.Web.UI.Page {
        readonly ClienteLogic cliLog = new ClienteLogic();
        protected void Page_Load(object sender, EventArgs e) {
            
            
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
                        Response.Write("<script language='javascript'>alert('Contraseña incorrecta')</script>");
                    }
                }
                else
                {
                    // Mensaje de usuario inexistente
                    Response.Write("<script language='javascript'>alert('Ese usuario no existe')</script>");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
        }
    }
    }