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
using DAL;

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
                ClienteLogic cliLog = new ClienteLogic();
                dgvClientes.DataSource = cliLog.GetAll();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.yaguaronDBDataSet.clientes);
            Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Alta);
            cliente.ShowDialog();
            this.Listar();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            /*if (this.dgvClientes.SelectedRows != null)
            {
                int ID = ((cliente)this.dgvClientes.SelectedRows[0].DataBoundItem).id_cliente;
                ABMClientes cliente = new ABMClientes(ID, ApplicationForm.ModoForm.Modificacion);
                cliente.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna fila");
            }*/

            int? id = GetId();
            if (id!=null)
            {
                ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Modificacion, id);
                cliente.ShowDialog();
                this.Listar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /*if (this.dgvClientes.SelectedRows != null)
            {
                int ID = ((cliente)this.dgvClientes.SelectedRows[0].DataBoundItem).id_cliente;
                ABMClientes cliente = new ABMClientes(ID, ApplicationForm.ModoForm.Baja);
                cliente.ShowDialog();
                this.Listar();
            }
            else
            {
                MessageBox.Show("No seleccionaste ninguna fila");
            }*/

            int? id = GetId();
            if (id != null)
            {
                ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Baja, id);
                cliente.ShowDialog();
                this.Listar();
            }
        }
    }
}
