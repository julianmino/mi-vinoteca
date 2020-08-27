﻿using System;
using System.Windows.Forms;
namespace UI.Desktop {
    public partial class ApplicationForm : Form {

        public enum ModoForm {
            Alta,
            Baja,
            Modificacion,
            Consulta
            }

        private ModoForm _Modo;
        public ModoForm Modo { get => _Modo; set => _Modo = value; }

        public ApplicationForm() {
            InitializeComponent();
            }

        private void ApplicationForm_Load(object sender, EventArgs e) {

            }

        public virtual void MapearDeDatos() {

            }

        public virtual void MapearADatos() {

            }

        public virtual void GuardarCambios() {

            }

        public virtual bool Validar() {
            return false;
            }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono) {
            MessageBox.Show(mensaje, titulo, botones, icono);
            }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono) {
            this.Notificar(this.Text, mensaje, botones, icono);
            }
        }
    }
