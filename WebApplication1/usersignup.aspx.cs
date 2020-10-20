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

        protected bool Validar_Usaurio(string usrname) {
            ClienteLogic cliLog = new ClienteLogic();
            cliente cliActual = cliLog.GetOne(usrname);

            if (cliActual is null) {
                return true;
                }
            else {
                // Muestra que ese nombre de usuario ya existe
                lblUsuario.Visible = true;
                return false;
                }
            }
        protected void btnRegistrar_Click(object sender, EventArgs e) {
            bool usuario_valido = Validar_Usaurio(txtUsuario.Text);

            if (Page.IsValid & usuario_valido) {
                Registrar();
                //volver a homepage
                Response.Redirect("homepage.aspx");
                }
            }
        }
    }   