using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop {
    public partial class Clientes : Form {
        public Clientes() {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
            }

        public void Listar() {
            ClienteLogic cliLog = new ClienteLogic();
            dgvClientes.DataSource = cliLog.GetAll();
            }

        public void ListarFiltrados(string filtro)
        {
            ClienteLogic cliLog = new ClienteLogic();
            dgvClientes.DataSource = cliLog.ConsultaEnTabla(filtro);
        }

        private void Clientes_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.yaguaronDBDataSet.clientes);
            Listar();
            }

        private void btnAgregar_Click(object sender, EventArgs e) {
            ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Alta);
            cliente.ShowDialog();
            this.Listar();
            }

        private int? GetId() {
            try {
                return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
                }
            catch {
                return null;
                }
            }
        private void btnModificar_Click(object sender, EventArgs e) {
            int? id = GetId();
            if (id != null) {
                ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Modificacion, id);
                cliente.ShowDialog();
                this.Listar();
                }
            }

        private void btnBorrar_Click(object sender, EventArgs e) {
            int? id = GetId();
            if (id != null) {
                ABMClientes cliente = new ABMClientes(ApplicationForm.ModoForm.Baja, id);
                cliente.ShowDialog();
                this.Listar();
                }
            }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            ListarFiltrados(txtConsulta.Text);
        }
    }
    }
