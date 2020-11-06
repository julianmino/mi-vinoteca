using Business.Logic;
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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
            dgvPedidos.AutoGenerateColumns = false;
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            
            Listar();
        }
        public void Listar()
        {
            PedidoLogic pedidoLog = new PedidoLogic();
            dgvPedidos.DataSource = pedidoLog.GetAll();
        }
    }
}
