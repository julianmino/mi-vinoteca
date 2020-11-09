using System;
using System.Windows.Forms;
using Business.Logic;
using DAL;

namespace UI.Desktop {
    public partial class ABMProductores : ApplicationForm {
        private productores ProductorActual;
        private ProductorLogic prodLog = new ProductorLogic();
        private ProductoLogic productoLog = new ProductoLogic();
        public ABMProductores() {
            InitializeComponent();
            }
        public ABMProductores(ModoForm modo) : this() {
            Modo = modo;
            }

        public ABMProductores(ModoForm modo, int id_productor) : this() {
            Modo = modo;
            
            ProductorActual = prodLog.GetOne(id_productor);
            this.MapearDeDatos();
                
            }
        public override void MapearDeDatos() {
            txtID.Text = ProductorActual.id_productor.ToString();
            txtNombre.Text = ProductorActual.nombre;

            switch (this.Modo) {
                case ModoForm.Alta: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Modificacion: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: this.btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Consulta: this.btnAceptar.Text = "Aceptar"; break;
                }
            }
        public override void MapearADatos() {

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion) {
                if (this.Modo == ModoForm.Alta) {

                    prodLog.Alta(txtNombre.Text);
                    }
                else {
                    prodLog.Modificacion(Convert.ToInt32(txtID.Text),
                        txtNombre.Text);
                    }
                }
            else if (this.Modo == ModoForm.Baja) {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar " + txtNombre.Text + " de la base de datos?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    foreach (productos p in ProductorActual.productos)
                    {
                        productoLog.Baja(p.id_producto);
                    }
                    prodLog.Baja(int.Parse(txtID.Text));
                    }
                }
            }

        private void ABMProductores_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.productores' table. You can move, or remove it, as needed.
            this.productoresTableAdapter.Fill(this.yaguaronDBDataSet.productores);            

            if (Modo == ModoForm.Baja) {
                txtNombre.ReadOnly = true;
                }

            }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if (Validar())
            {
                MapearADatos();
                this.Dispose();
            }
            
            }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Dispose();
            }

        public override bool Validar()
        {
            bool ban = false;
            msgNombre.Visible = !String.IsNullOrEmpty(msgNombre.Text);

            productores prod = prodLog.GetOne(txtNombre.Text);
            if (prod == null || Modo == ModoForm.Modificacion)
            {
                ban = true;
            }
            ban = (Modo == ModoForm.Baja) ? true : ban;
            return ban;
        }
    }
}
        
