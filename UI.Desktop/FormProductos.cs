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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.yaguaronDBDataSet.productos);

        }
    }
}
