using System;
using System.Windows.Forms;
using Business.Logic;
using DAL;

namespace UI.Desktop {
    public partial class ABMProductores : ApplicationForm {
        public productores ProductorActual;

        public ABMProductores() {
            InitializeComponent();
            }
        public ABMProductores(ModoForm modo) : this() {
            Modo = modo;
            }

        public ABMProductores(ModoForm modo, int id_productor) : this() {
            Modo = modo;
            ProductorLogic prodLog = new ProductorLogic();
            
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
            ProductorLogic prodLog = new ProductorLogic();

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
            MapearADatos();
            this.Dispose();
            }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Dispose();
            }        
        }
    }
        
