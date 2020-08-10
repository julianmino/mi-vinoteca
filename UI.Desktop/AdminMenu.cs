<<<<<<< HEAD
﻿using System;
=======
﻿using Business.Entities;
using System;
>>>>>>> adminMenu
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
<<<<<<< HEAD
        private Form formActivo = null;
=======

        private Form formActivo = null;

>>>>>>> adminMenu
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
<<<<<<< HEAD

=======
            customDesign();
>>>>>>> adminMenu
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            if (panelSideMenu.Width == 80)
            {
                panelSideMenu.Width = 250;
            }
>>>>>>> adminMenu
            displaySubmenu(panelProductosSubmenu);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            displaySubmenu(panelClientesSubmenu);
        }

        private void abrirFormHijo(Form formHijo)
=======
            if (panelSideMenu.Width == 80)
            {
                panelSideMenu.Width = 250;
            }
            displaySubmenu(panelClientesSubmenu);
        }

        public void abrirFormHijo(Form formHijo, string lblFormActivo)
>>>>>>> adminMenu
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

<<<<<<< HEAD
=======
            lblFormActual.Text = lblFormActivo;

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            
            abrirFormHijo(new Clientes(), "Todos los Clientes");

        }


        private void resizeSideMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Width == 250)
            {
                panelSideMenu.Width = 80;
                panelClientesSubmenu.Visible = false;
                panelProductosSubmenu.Visible = false;
            }
            else
            {
                panelSideMenu.Width = 250;
            }
>>>>>>> adminMenu
        }
    }
}
