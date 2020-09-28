using Business.Logic;
using DAL;
using System;
using System.Windows.Forms;

namespace UI.Desktop {
    public partial class ABMClientes : ApplicationForm {
        public cliente ClienteActual;
        public ABMClientes() {
            InitializeComponent();
            }

        public ABMClientes(ModoForm modo) : this() {
            Modo = modo;
            }

        public ABMClientes(ModoForm modo, string usuario) : this(){
            Modo = modo;
            ClienteLogic cliLog = new ClienteLogic();
            if (usuario != null) {
                ClienteActual = cliLog.GetOne(usuario);
                this.MapearDeDatos();
                }
            }

        public override void MapearDeDatos() {

            this.txtNombre.Text = this.ClienteActual.nombre;
            this.txtApellido.Text = this.ClienteActual.apellido;
            this.txtUsuario.Text = this.ClienteActual.usuario;
            this.txtEmail.Text = this.ClienteActual.email;
            this.txtClave.Text = this.ClienteActual.clave;
            this.pickerFechaNac.Value = this.ClienteActual.fecha_nac;
            this.ckbPremium.Checked = this.ClienteActual.premium;
            this.cbEstado.Text = this.ClienteActual.estado;

            if (this.ClienteActual.id_descuento is null) {
                this.txtDescuento.Text = null;
                }
            else {
                this.txtDescuento.Text = this.ClienteActual.id_descuento.ToString();
                }

            switch (this.Modo) {
                case ModoForm.Alta: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Modificacion: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: this.btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Consulta: this.btnAceptar.Text = "Aceptar"; break;
                }
            }

        public override void MapearADatos() {
            ClienteLogic cliLog = new ClienteLogic();

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion) {
                int? descuento;

                if (String.IsNullOrEmpty(txtDescuento.Text) || Double.IsNaN(int.Parse(txtDescuento.Text))) {
                    descuento = null;
                    }
                else {
                    descuento = int.Parse(txtDescuento.Text);
                    }

                if (this.Modo == ModoForm.Alta) {

                    cliLog.Alta(txtNombre.Text, txtApellido.Text, txtUsuario.Text, txtEmail.Text, txtClave.Text, pickerFechaNac.Value, ckbPremium.Checked, descuento, cbEstado.Text);
                    }
                else {

                     //CAMBIAR
                    cliLog.Modificacion(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtClave.Text, pickerFechaNac.Value, ckbPremium.Checked, descuento, cbEstado.Text);
                    }
                }

            else if (this.Modo == ModoForm.Baja) {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar a " + txtNombre.Text + " " + txtApellido.Text + " de la base de datos?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {

                    //CAMBIAR
                    cliLog.Baja(txtUsuario.Text);
                    }
                }
            }

        public override bool Validar() {
            // Los valores de los msgLabel son seteados en los eventos TextChanged de cada TextBox
            bool ban = false;

            msgNombre.Visible = !String.IsNullOrEmpty(msgNombre.Text);
            msgApellido.Visible = !String.IsNullOrEmpty(msgApellido.Text);
            msgUsuario.Visible = !String.IsNullOrEmpty(msgUsuario.Text);
            msgEmail.Visible = !String.IsNullOrEmpty(msgEmail.Text);
            msgClave.Visible = !String.IsNullOrEmpty(msgClave.Text);
            msgConfirmarClave.Visible = !String.IsNullOrEmpty(msgConfirmarClave.Text);

            if (!msgNombre.Visible) {
                if (!msgApellido.Visible) {
                    if (!msgUsuario.Visible) {
                        if (!msgEmail.Visible) {
                            if (!msgClave.Visible) {
                                if (!msgConfirmarClave.Visible) {
                                    ban = true;
                                    }
                                }
                            }
                        }
                    }
                }

            return ban;
            }

        private void btnAceptar_Click(object sender, EventArgs e) {
            Validar();
            if (Validar()) {
                MapearADatos();
                this.Dispose();
                }
            }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Dispose();
            }

        private void ABMClientes_Load(object sender, EventArgs e) {
            pickerFechaNac.MaxDate = DateTime.Now.AddYears(-18);
            txtDescuento.ReadOnly = (ckbPremium.Checked) ? false : true;

            //Seteo de ReadOnly si el Formulario es de Baja o de Consulta
            if (Modo == ModoForm.Baja || Modo == ModoForm.Consulta) {
                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtClave.ReadOnly = true;
                pickerFechaNac.Enabled = false;
                ckbPremium.Enabled = false;
                txtDescuento.ReadOnly = true;
                cbEstado.Enabled = false;
                }
            }

        private void ckbPremium_CheckedChanged(object sender, EventArgs e) {
            txtDescuento.ReadOnly = (ckbPremium.Checked) ? false : true;
            txtDescuento.Text = (!ckbPremium.Checked && !String.IsNullOrEmpty(txtDescuento.Text)) ? null : txtDescuento.Text;
            }

        private void txtNombre_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNombre.Text)) {
                msgNombre.Text = "Debe ingresar un nombre";
                }
            else {
                msgNombre.Text = null;
                }

            msgNombre.Visible = !String.IsNullOrEmpty(msgNombre.Text);
            }

        private void txtApellido_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtApellido.Text)) {
                msgApellido.Text = "Debe ingresar un apellido";
                }
            else {
                msgApellido.Text = null;
                }

            msgApellido.Visible = (msgApellido.Text == null) ? false : true;
            }

        private void txtUsuario_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtUsuario.Text)) {
                msgUsuario.Text = "Debe ingresar un nombre de usuario";
                }
            else {
                msgUsuario.Text = null;
                }
            msgUsuario.Visible = (msgUsuario.Text == null) ? false : true;
            }

        private void txtEmail_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtEmail.Text)) {
                msgEmail.Text = "Debe ingresar un email";
                }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com")) {
                msgEmail.Text = "El email posee un formato inválido";
                }
            else {
                msgEmail.Text = null;
                }
            msgEmail.Visible = (msgEmail.Text == null) ? false : true;
            }

        private void txtClave_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtClave.Text)) {
                msgClave.Text = "Debe ingresar una clave";
                }
            else if (txtClave.TextLength < 6) {
                msgClave.Text = "Debe ingresar una clave con 6 o más caracteres";
                if (!String.IsNullOrEmpty(txtConfirmarClave.Text)) {
                    if (txtClave.Text != txtConfirmarClave.Text) {
                        msgConfirmarClave.Text = "Las claves ingresadas no coinciden";
                        }
                    else {
                        msgConfirmarClave.Text = null;
                        }
                    }

                }
            else if (txtClave.Text != txtConfirmarClave.Text && !String.IsNullOrEmpty(txtConfirmarClave.Text)) {
                msgClave.Text = null;
                msgConfirmarClave.Text = "Las claves ingresadas no coinciden";
                }
            else if (txtClave.Text == txtConfirmarClave.Text) {
                msgClave.Text = null;
                msgConfirmarClave.Text = null;
                }
            else {
                msgClave.Text = null;
                }
            msgClave.Visible = (msgClave.Text == null) ? false : true;
            }

        private void txtConfirmarClave_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtConfirmarClave.Text)) {
                msgConfirmarClave.Text = "Debe confirmar la clave";
                }
            else if (txtClave.Text != txtConfirmarClave.Text) {
                msgConfirmarClave.Text = "Las claves ingresadas no coinciden";
                }
            else {
                msgConfirmarClave.Text = null;
                }
            msgConfirmarClave.Visible = (msgConfirmarClave.Text == null) ? false : true;
            }
        }
    }
