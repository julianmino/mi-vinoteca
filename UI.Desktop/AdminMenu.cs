using Business.Entities;
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
    public partial class AdminMenu : Form
    {

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        private ModoForm _Modo;
        public ModoForm Modo { get => _Modo; set => _Modo = value; }

        private Form formActivo = null;

        public Cliente ClienteActual;

        public virtual void MapearDeDatos()
        {

        }

        public virtual void MapearADatos()
        {

        }

        public virtual void GuardarCambios()
        {

        }

        public virtual bool Validar()
        {
            return false;
        }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void customDesign()
        {
            panelClientesSubmenu.Visible = false;
            panelProductosSubmenu.Visible = false;

        }

        private void displaySubmenu(Panel subMenu)
        {
            if (subMenu.Visible)
            {
                subMenu.Visible = false;
            }
            else
            {
                subMenu.Visible = true;
            }
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            displaySubmenu(panelProductosSubmenu);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            displaySubmenu(panelClientesSubmenu);
        }

        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo!=null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(formHijo);
            panelFormHijo.Tag = formActivo;
            formHijo.Show();

        }
    }
}
