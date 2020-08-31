using System;
using System.Windows.Forms;
using Business.Logic;
using DAL;

namespace UI.Desktop {
    public partial class ABMProductos : ApplicationForm {
        public producto ProductoActual;
        public int? id;
        private int _id_tipo;
        public int Id_tipo { get => _id_tipo; set => _id_tipo = value; }
        public ABMProductos() {
            InitializeComponent();
            }
        public ABMProductos(ModoForm modo, int id_tipo) : this() {
            Modo = modo;
            Id_tipo = id_tipo;
            }            
        public ABMProductos(ModoForm modo, int id_tipo, int? id = null) : this(){
            this.id = id;
            Modo = modo;
            Id_tipo = id_tipo;
            ProductoLogic prodLog = new ProductoLogic();

            if (this.id != null) {
                ProductoActual = prodLog.GetOne((int)this.id);
                this.MapearDeDatos();
                }
            }
        public override void MapearDeDatos() {
            txtID.Text = ProductoActual.id_producto.ToString();
            txtNombre.Text = ProductoActual.nombre;
            txtProductor.Text = ProductoActual.productor;            
            numMl.Value = Convert.ToDecimal(ProductoActual.ml);
            numVolumenAlcohol.Value = Convert.ToDecimal(ProductoActual.vol_alcohol);
            numPrecio.Value = Convert.ToDecimal(ProductoActual.precio);
            numStock.Value = ProductoActual.stock;
            //Mapear a 0 los campos que son NULL en la DB
            if (ProductoActual.añejamiento == null) {
                numAniejamiento.Value = 0M;
                }
            else {
                numAniejamiento.Value = Convert.ToInt32(ProductoActual.añejamiento);
                    }
            if (ProductoActual.año == null) {
                numAnio.Value = 0M;
                }
            else {
                numAnio.Value = Convert.ToInt32(ProductoActual.año);
                    }
            if (ProductoActual.ibu == null) {
                numIBU.Value = 0M;
                }
            else {
                numIBU.Value = Convert.ToInt32(ProductoActual.ibu);
                    }

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
                        Convert.ToInt32(numAniejamiento.Value),
                        Id_tipo);
                    }
                else {
                    prodLog.Modificacion(int.Parse(txtID.Text), txtNombre.Text, txtProductor.Text,
                        Convert.ToDouble(numPrecio.Value),
                        Convert.ToInt32(numStock.Value),
                        Convert.ToDouble(numVolumenAlcohol.Value),
                        Convert.ToDouble(numMl.Value), Convert.ToDouble(numIBU.Value),
                        Convert.ToInt32(numAnio.Value),
                        Convert.ToInt32(numAniejamiento.Value),
                        Id_tipo);
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

            if (Modo == ModoForm.Baja || Modo == ModoForm.Consulta) {
                txtNombre.ReadOnly = true;
                txtProductor.Enabled = false;
                numIBU.ReadOnly = true;
                numAniejamiento.ReadOnly = true;
                numAnio.ReadOnly = true;
                numMl.ReadOnly = true;
                numPrecio.Enabled = false;
                numVolumenAlcohol.ReadOnly = true;
                numStock.ReadOnly = true;
            }
            //Ocultar los campos que no mapean
            switch (Id_tipo) {
                //Para vinos, licores y whiskies
                case 1 :
                case 3 :
                case 4 :
                    numIBU.Visible = false;
                    lblIBU.Visible = false;
                    break;                
                //Para Cervezas
                case 2:
                    numAniejamiento.Visible = false;
                    lblAniejamiento.Visible = false;
                    break;
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
        
