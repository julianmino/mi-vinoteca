using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop {
    public partial class AdminMenu : Form {

        private Form formActivo = null;

        public AdminMenu() {
            InitializeComponent();
            }

        private void customDesign() {
            panelClientesSubmenu.Visible = false;
            panelProductosSubmenu.Visible = false;

            }

        private void displaySubmenu(Panel subMenu) {
            if (subMenu.Visible) {
                subMenu.Visible = false;
                }
            else {
                subMenu.Visible = true;
                }
            }

        private void MenuAdmin_Load(object sender, EventArgs e) {
            customDesign();
            }

        private void btnProductos_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 80) {
                panelSideMenu.Width = 250;
                }
            displaySubmenu(panelProductosSubmenu);
            }

        private void btnClientes_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 80) {
                panelSideMenu.Width = 250;
                }
            displaySubmenu(panelClientesSubmenu);
            }

        public void abrirFormHijo(Form formHijo, string lblFormActivo) {
            if (formActivo != null) {
                formActivo.Close();
                }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelFormHijo.Controls.Add(formHijo);
            panelFormHijo.Tag = formActivo;
            formHijo.Show();

            lblFormActual.Text = lblFormActivo;

            }
        private void resizeSideMenu_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 250) {
                panelSideMenu.Width = 100;
                panelClientesSubmenu.Visible = false;
                panelProductosSubmenu.Visible = false;
                }
            else {
                panelSideMenu.Width = 250;
                }
            }
        private void btnTodos_Click(object sender, EventArgs e) {
            abrirFormHijo(new Clientes(), "Todos los Clientes");

            }
        private void btnVinos_Click(object sender, EventArgs e) {
            abrirFormHijo(new Productos(Productos.TipoForm.Vino), "Vinos");
            }

        private void btnWhiskies_Click(object sender, EventArgs e) {
            abrirFormHijo(new Productos(Productos.TipoForm.Whisky), "Whiskies");
            }

        private void btnCervezas_Click(object sender, EventArgs e) {
            abrirFormHijo(new Productos(Productos.TipoForm.Cerveza), "Cervezas");
            }

        private void btnLicores_Click(object sender, EventArgs e) {
            abrirFormHijo(new Productos(Productos.TipoForm.Licor), "Licores");
            }
        private void btnProductores_Click(object sender, EventArgs e) {
            abrirFormHijo(new Productores(), "Productores");
            }
        
        private void txtConsulta_TextChanged(object sender, EventArgs e) {

            }

        }
    }
