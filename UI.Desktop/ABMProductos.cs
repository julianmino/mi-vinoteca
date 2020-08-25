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
            numAniejamiento.Value = Convert.ToInt32(ProductoActual.añejamiento);
            numAnio.Value = Convert.ToInt32(ProductoActual.año);
            numIBU.Value = Convert.ToDecimal(ProductoActual.ibu);
            numMl.Value = Convert.ToDecimal(ProductoActual.ml);
            txtNombre.Text = ProductoActual.nombre;
            numPrecio.Value = Convert.ToDecimal(ProductoActual.precio);
            txtProductor.Text = ProductoActual.productor;
            numStock.Value = ProductoActual.stock;            

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
                    prodLog.Alta(txtNombre.Text, txtProductor.Text,Convert.ToDouble(numPrecio.Value),
                        Convert.ToInt32(numStock.Value),
                        Convert.ToDouble(numVolumenAlcohol.Value),
                        Convert.ToDouble(numMl.Value), Convert.ToDouble(numIBU.Value),
                        Convert.ToInt32(numAnio.Value),
                        Convert.ToInt32(numAniejamiento.Value));
                    }
                else {
                    prodLog.Modificacion(int.Parse(txtID.Text), txtNombre.Text, txtProductor.Text,
                        Convert.ToDouble(numPrecio.Value),
                        Convert.ToInt32(numStock.Value),
                        Convert.ToDouble(numVolumenAlcohol.Value),
                        Convert.ToDouble(numMl.Value), Convert.ToDouble(numIBU.Value),
                        Convert.ToInt32(numAnio.Value),
                        Convert.ToInt32(numAniejamiento.Value));
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
        
