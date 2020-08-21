using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using DAL;

namespace UI.Desktop {
    public partial class ABMProductos : ApplicationForm {
        public producto ProductoActual;
        public int? id;
        public ABMProductos() {
            InitializeComponent();
            }
        public ABMProductos(ModoForm modo) : this() {
            Modo = modo;
            }
        public ABMProductos(ModoForm modo, int? id = null) : this() {
            this.id = id;
            Modo = modo;
            ProductoLogic prodLog = new ProductoLogic();
            if (this.id != null) {
                ProductoActual = prodLog.GetOne((int)this.id);
                this.MapearDeDatos();
                }
            }
        public override void MapearDeDatos() {
            txtID.Text = ProductoActual.id_producto.ToString();
            txtAnejamiento.Text = ProductoActual.añejamiento.ToString();
            txtAnio.Text = ProductoActual.año.ToString();
            txtIBU.Text = ProductoActual.ibu.ToString();
            txtML.Text = ProductoActual.ml.ToString();
            txtNombre.Text = ProductoActual.nombre;
            txtPrecio.Text = ProductoActual.precio.ToString();
            txtProductor.Text = ProductoActual.productor;
            txtStock.Text = ProductoActual.stock.ToString();
            cmbxTipo.Text = ProductoActual.tipo;

            switch (this.Modo) {
                case ModoForm.Alta: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Modificacion: this.btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: this.btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Consulta: this.btnAceptar.Text = "Aceptar"; break;

                }

            }
        public override void MapearADatos() {
            ProductoLogic prodLog = new ProductoLogic();

            if (this.Modo == ModoForm.Alta || this.Modo == ModoForm.Modificacion) {
                if (this.Modo == ModoForm.Alta) {
                    prodLog.Alta(txtNombre.Text, txtProductor.Text, double.Parse(txtPrecio.Text),
                        int.Parse(txtStock.Text), cmbxTipo.Text, double.Parse(txtVolumenAlcohol.Text),
                        double.Parse(txtML.Text), double.Parse(txtIBU.Text), int.Parse(txtAnio.Text),
                        int.Parse(txtAnejamiento.Text)
                       );
                    }
                else {
                    prodLog.Modificacion(int.Parse(txtID.Text), txtNombre.Text, txtProductor.Text, double.Parse(txtPrecio.Text),
                        int.Parse(txtStock.Text), cmbxTipo.Text, double.Parse(txtVolumenAlcohol.Text),
                        double.Parse(txtML.Text), double.Parse(txtIBU.Text), int.Parse(txtAnio.Text),
                        int.Parse(txtAnejamiento.Text));
                    }                
                }
                else if (this.Modo == ModoForm.Baja) {
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar " + txtNombre.Text + " de " + txtProductor.Text + " de la base de datos?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) {
                        prodLog.Baja(int.Parse(txtID.Text));
                        }
                }
            }

        private void ABMProductos_Load(object sender, EventArgs e) {
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
        
