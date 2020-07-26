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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet2.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.yaguaronDBDataSet2.clientes);

        }
    }
}
