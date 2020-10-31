using System;
using DAL;
using Business.Logic;
using System.Web;

namespace WebApplication1 {

    public partial class usersingup : System.Web.UI.Page {

        private ClienteLogic cliLog = new ClienteLogic();
        public void Registrar() {
            DateTime dt = DateTime.Parse(txtFechaNac.Text);
            cliLog.Alta(txtNombre.Text.Trim(), txtApellido.Text.Trim(), txtUsuario.Text.Trim(),
                        txtEmail.Text.Trim(), txtPassword.Text.Trim(), dt, false, null, "Pendiente");
            }
        protected void Page_Load() {
            rvFechaNac.MaximumValue = DateTime.Today.AddYears(-18).ToString("yyyy-MM-dd");
            }

        protected bool Validar_Usaurio(string usrname) {
            clientes cliActual = cliLog.GetOne(usrname);
            bool ban = false;
            if (cliActual is null) {
                ban = true;
                }
            lblUsuario.Visible = !ban;
            return ban;
            }

        protected bool Validar_Email(string email)
        {
            bool ban = true;
            clientes[] clientes = cliLog.GetAll().ToArray();
            foreach (clientes c in clientes)
            {
                if (c.email == email)
                {
                    ban = false;
                    break;
                }
            }
            lblEmailRegistrado.Visible = !ban;
            return ban;
        }
        protected void btnRegistrar_Click(object sender, EventArgs e) {
            bool usuario_valido = Validar_Usaurio(txtUsuario.Text);
            bool email_valido = Validar_Email(txtEmail.Text);
            if (Page.IsValid && usuario_valido && email_valido) {
                Registrar();
                //volver a homepage
                Response.Redirect("homepage.aspx");
                }
            }
        }
    }   