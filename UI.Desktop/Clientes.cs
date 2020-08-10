using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;
using Data.Database;

namespace UI.Desktop
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            ClienteAdapter cliAdap = new ClienteAdapter();
            ClienteLogic cliLog = new ClienteLogic(cliAdap);

            this.dgvClientes.DataSource = cliAdap.GetAll();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet3.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter1.Fill(this.yaguaronDBDataSet3.clientes);
            // TODO: This line of code loads data into the 'yaguaronDBDataSet2.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.yaguaronDBDataSet2.clientes);
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Alta);
            cliente.ShowDialog();
            this.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.SelectedRows != null)
            {
                int ID = ((Cliente)this.dgvClientes.SelectedRows[0].DataBoundItem).ID;
                ABMClientes cliente = new ABMClientes(ID, ApplicationForm.ModoForm.Modificacion);
                cliente.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna fila");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.SelectedRows != null)
            {
                int ID = ((Cliente)this.dgvClientes.SelectedRows[0].DataBoundItem).ID;
                ABMClientes cliente = new ABMClientes(ID, ApplicationForm.ModoForm.Baja);
                cliente.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna fila");
            }
        }
    }
}
