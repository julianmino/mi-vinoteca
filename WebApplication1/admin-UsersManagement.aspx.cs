using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using DAL;
namespace WebApplication1
{
    public partial class admin_UsersManagement : System.Web.UI.Page
    {
        ClienteLogic cliLog = new ClienteLogic();
        cliente clienteActual;

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = cliLog.GetAll();
            dgvUsuarios.DataBind();
        }

        protected void btnCheckPressed(object sender, EventArgs e)
        {
                
                clienteActual = cliLog.GetByUser(txtUsuario.Text);
                
                if (clienteActual != null)
                {
                    txtEstado.Text = clienteActual.estado;
                    txtEstado.Font.Bold = true;
                    txtNombre.Text = clienteActual.nombre;
                    txtApellido.Text = clienteActual.apellido;
                    txtEmail.Text = clienteActual.email;
                    txtFechaNac.Text = clienteActual.fecha_nac.ToString("dd/MM/yyyy");
                    
                    btnHabilitado.Visible = true;
                    btnPendiente.Visible = true;
                    btnCancelado.Visible = true;
                }
        }


        protected void btnHabilitadoPressed(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    cliLog.CambiarEstado(clienteActual, "habilitado");
                
                } catch (Exception)
                {
                    throw;
                }
                txtEstado.Text = "habilitado";
            } catch (Exception)
            {
                throw;
            }
                
         }
            
    }
}