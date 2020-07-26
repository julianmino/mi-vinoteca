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
        private Form formActivo = null;
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
