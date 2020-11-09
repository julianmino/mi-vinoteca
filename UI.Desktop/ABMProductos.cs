﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Business.Logic;
using DAL;

namespace UI.Desktop {
    public partial class ABMProductos : ApplicationForm {
        public productos ProductoActual;
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
        public ABMProductos(ModoForm modo, int id_tipo, int? id = null) : this() {
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
            numMl.Value = Convert.ToDecimal(ProductoActual.ml);
            numVolumenAlcohol.Value = Convert.ToDecimal(ProductoActual.vol_alcohol);
            numPrecio.Value = Convert.ToDecimal(ProductoActual.precio);
            numStock.Value = ProductoActual.stock;

            if (ProductoActual.foto != null) {
                //Convierte la imagen de byte[] a Image
                MemoryStream ms = new MemoryStream(ProductoActual.foto);
                Image foto = Image.FromStream(ms);
                pictBoxFoto.Image = foto;
                }
            else {
                pictBoxFoto.Image = default;
                }
            ;

            //Mapear a 0 los campos que son NULL en la DB
            if (ProductoActual.añejamiento == null) {
                numAniejamiento.Value = 0M;
                }
            else {
                numAniejamiento.Value = Convert.ToInt32(ProductoActual.añejamiento);
                }
            if (ProductoActual.año == null) {
                numAnio.Value = 2000M;
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
                // Guarda la foto
                byte[] foto = File.ReadAllBytes(fileDialogFoto.FileName);
                
                if (this.Modo == ModoForm.Alta) {

                    prodLog.Alta(txtNombre.Text,
                        Convert.ToInt32(cbProductor.SelectedValue),
                        Convert.ToDouble(numPrecio.Value),
                        Convert.ToInt32(numStock.Value),
                        Convert.ToDouble(numVolumenAlcohol.Value),
                        Convert.ToDouble(numMl.Value), Convert.ToDouble(numIBU.Value),
                        Convert.ToInt32(numAnio.Value),
                        Convert.ToInt32(numAniejamiento.Value),
                        Id_tipo,
                        foto);
                    }
                else {
                    prodLog.Modificacion(int.Parse(txtID.Text),
                        txtNombre.Text,
                        Convert.ToInt32(cbProductor.SelectedValue),
                        Convert.ToDouble(numPrecio.Value),
                        Convert.ToInt32(numStock.Value),
                        Convert.ToDouble(numVolumenAlcohol.Value),
                        Convert.ToDouble(numMl.Value),
                        Convert.ToDouble(numIBU.Value),
                        Convert.ToInt32(numAnio.Value),
                        Convert.ToInt32(numAniejamiento.Value),
                        Id_tipo,
                        foto);
                    }
                }
            else if (this.Modo == ModoForm.Baja) {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar " + txtNombre.Text + " de " + cbProductor.Text + " de la base de datos?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    prodLog.Baja(int.Parse(txtID.Text));
                    }
                }
            }

        private void ABMProductos_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.productores' table. You can move, or remove it, as needed.
            this.productoresTableAdapter.Fill(this.yaguaronDBDataSet.productores);            

            if (Modo == ModoForm.Baja) {
                txtNombre.ReadOnly = true;
                cbProductor.Enabled = false;
                numIBU.Enabled = false;
                numAniejamiento.Enabled = false;
                numAnio.Enabled = false;
                numMl.Enabled = false;
                numPrecio.Enabled = false;
                numVolumenAlcohol.Enabled = false;
                numStock.Enabled = false;
                btnFoto.Enabled = false;
                }

            // Mapear el combobox
            if (Modo == ModoForm.Baja || Modo == ModoForm.Modificacion) {
                cbProductor.SelectedValue = ProductoActual.id_productor;
                }

            // Ocultar los campos que no mapean
            switch (Id_tipo) {
                //Para vinos, licores y whiskies
                case 0:
                case 2:
                case 3:
                    numIBU.Visible = false;
                    lblIBU.Visible = false;
                    break;
                //Para Cervezas
                case 1:
                    numAnio.Visible = false;
                    lblAnio.Visible = false;
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

        private void btnFoto_Click(object sender, EventArgs e) {

            if(fileDialogFoto.ShowDialog() == DialogResult.OK) {
                pictBoxFoto.Image = new Bitmap(fileDialogFoto.FileName);
                lblFoto.ForeColor = Color.Green;
                lblFoto.Text = fileDialogFoto.FileName;
                }
            }
        }
    //Falta Validación de producto ya existente, como en ABMClientes
    }
        
