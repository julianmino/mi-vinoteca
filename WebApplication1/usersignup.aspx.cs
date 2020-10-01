using System;
using DAL;
using Business.Logic;
using System.Web;

namespace WebApplication1 {

    public partial class usersingup : System.Web.UI.Page {

        public void Registrar() {
            ClienteLogic cliLog = new ClienteLogic();
            DateTime dt = DateTime.Parse(txtFechaNac.Text);
            cliLog.Alta(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtUsuario.Text.Trim(),
                        txtEmail.Text.Trim(), txtPassword.Text.Trim(), dt, false, null, "Pendiente");
            }
        protected void Page_Load() {
            rvFechaNac.MaximumValue = DateTime.Today.AddYears(-18).ToString("yyyy-MM-dd");
            }
        protected void btnRegistrar_Click(object sender, EventArgs e) {
            if (Page.IsValid) {
                Registrar();
                //volver a homepage
                Response.Redirect("homepage.aspx");
                }
            }
        }
    }   