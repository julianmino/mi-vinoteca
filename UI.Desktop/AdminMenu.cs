using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI.Desktop
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);
        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconShrink.Visible = true;
            iconMaximize.Visible = false;
        }

        private void iconShrink_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconShrink.Visible = false;
            iconMaximize.Visible = true;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        
        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}
