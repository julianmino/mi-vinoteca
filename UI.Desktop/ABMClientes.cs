using Business.Entities;
using Business.Logic;
using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ClienteAdapter cliData = new ClienteAdapter();
            ClienteLogic cliLog = new ClienteLogic(cliData);
            ClienteActual = cliLog.GetOne(id);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ClienteActual.ID.ToString();
            this.txtNombre.Text = this.ClienteActual.Nombre;
            this.txtApellido.Text = this.ClienteActual.Apellido;
            this.txtUsuario.Text = this.ClienteActual.Usuario;
            this.txtEmail.Text = this.ClienteActual.Email;
            this.txtClave.Text = this.ClienteActual.Clave;
            this.pickerFechaNac.Value = this.ClienteActual.FechaNac;
            this.ckbPremium.Checked = this.ClienteActual.Premium;

            
           
            
            

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
            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion)
            {
                if (this.Modo == ModoForm.Alta)
                {
                    ClienteActual = new Cliente();
                    ClienteActual.State = BusinessEntity.States.New;
                }
                else
                {
                    this.ClienteActual.ID = int.Parse(this.txtID.Text);
                    this.ClienteActual.State = BusinessEntity.States.Modified;
                }

                this.ClienteActual.Nombre = this.txtNombre.Text;
                this.ClienteActual.Apellido = this.txtApellido.Text;
                this.ClienteActual.Usuario = this.txtUsuario.Text;
                this.ClienteActual.Email = this.txtEmail.Text;
                this.ClienteActual.Clave = this.txtClave.Text;
                this.ClienteActual.FechaNac = this.pickerFechaNac.Value;
                this.ClienteActual.Premium = this.ckbPremium.Checked;

            }

            else if (this.Modo == ModoForm.Baja)
            {
                this.ClienteActual.State = BusinessEntity.States.Deleted;
            }

            else
            {
                this.ClienteActual.State = BusinessEntity.States.Unmodified;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            ClienteAdapter cliData = new ClienteAdapter();
            ClienteLogic cliLog = new ClienteLogic(cliData);
            cliLog.Save(ClienteActual);
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
                GuardarCambios();
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
