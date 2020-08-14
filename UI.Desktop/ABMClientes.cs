using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace UI.Desktop
{
    public partial class ABMClientes:ApplicationForm
    {
        public ABMClientes()
        {
            InitializeComponent();
        }

        public ABMClientes(ModoForm modo):this()
        {
            Modo = modo;
        }

        public ABMClientes(int id, ModoForm modo):this()
        {
            Modo = modo;
            ClienteLogic cliLog = new ClienteLogic();
            cliente ClienteActual = cliLog.GetOne(id);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ClienteActual.id_cliente.ToString();
            this.txtNombre.Text = this.ClienteActual.nombre;
            this.txtApellido.Text = this.ClienteActual.apellido;
            this.txtUsuario.Text = this.ClienteActual.usuario;
            this.txtEmail.Text = this.ClienteActual.email;
            this.txtClave.Text = this.ClienteActual.clave;
            this.pickerFechaNac.Value = this.ClienteActual.fecha_nac;
            this.ckbPremium.Checked = this.ClienteActual.premium;

            switch (this.Modo)
            {
                case ModoForm.Alta: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Modificacion: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: this.btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Consulta: this.btnAceptar.Text = "Aceptar"; break;
            }
        }

        public override void MapearADatos()
        {
            ClienteLogic cliLog = new ClienteLogic();

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if (this.Modo == ModoForm.Alta)
                {
                    cliLog.Alta(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtClave.Text, pickerFechaNac.Value, ckbPremium.Checked, 0);
                }
                else
                {
                    cliLog.Modificacion(int.Parse(txtID.Text), txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtClave.Text, pickerFechaNac.Value, ckbPremium.Checked, 0); 
                }
            }

            else if (this.Modo == ModoForm.Baja)
            {
                cliLog.Baja(int.Parse(txtID.Text));
            }
        }

        public override bool Validar()
        {
            string errorMessage = "";
            bool ban = false;
            int error = 0;
            if (this.txtNombre.Text != null)
            {
                if (this.txtApellido.Text != null)
                {
                    if (this.txtClave.TextLength >= 6)
                    {
                        if (this.txtClave.Text == this.txtConfirmarClave.Text)
                        {
                            if (this.txtEmail.Text.Contains("@") && this.txtEmail.Text.Contains(".com"))
                            {
                                if (this.txtUsuario.Text != null)
                                {

                                    ban = true;
                                }
                                else { error = 6; }
                            }
                            else { error = 5; }

                        }
                        else { error = 4; }
                    }
                    else { error = 3; }
                }
                else { error = 2; }
            }
            else { error = 1; }

            if (!ban)
            {
                switch(error)
                {
                    case 1: errorMessage = "Debe ingresar un nombre";break;
                    case 2: errorMessage = "Debe ingresar un apellido";break;
                    case 3: errorMessage = "Debe ingresar una clave con más de 6 caracteres"; break;
                    case 4: errorMessage = "Las claves ingresadas no coinciden"; break;
                    case 5: errorMessage = "El email posee un formato inválido"; break;
                    case 6: errorMessage = "Debe ingresar un nombre de usuario"; break;
                    default: errorMessage = "";break;
                }
                this.Notificar(errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ban;
            }
            else
            {
                return ban;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Validar();
            if (Validar())
            {
                MapearADatos();
                this.Dispose();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            pickerFechaNac.MaxDate = DateTime.Now.AddYears(-18);
        }
    }
}
