using Business.Logic;
using System;
using System.Windows.Forms;

namespace UI.Desktop {
    public partial class Productos : Form {
        public Productos() {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
            }
        public void Listar() {
            ProductoLogic prodLog = new ProductoLogic();
            dgvProductos.DataSource = prodLog.GetAll();
            }
        private void btnAgregar_Click(object sender, EventArgs e) {
            ABMProductos producto = new ABMProductos(ApplicationForm.ModoForm.Alta);
            producto.ShowDialog();
            this.Listar();
            }
        private int? GetId() {
            try {
                return int.Parse(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                }
            catch {
                return null;
                }
            }

        private void Productos_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet1.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.yaguaronDBDataSet1.productos);
            Listar();
            }

        private void btnModificar_Click(object sender, EventArgs e) {
            int? id = GetId();
            if (id != null) {
                ABMProductos producto = new ABMProductos(ApplicationForm.ModoForm.Modificacion, id);
                producto.ShowDialog();
                this.Listar();
                }
            }

        private void btnBorrar_Click(object sender, EventArgs e) {
            int? id = GetId();
            if (id != null) {
                ABMProductos producto = new ABMProductos(ApplicationForm.ModoForm.Baja, id);
                producto.ShowDialog();
                this.Listar();
                }
            }
        }
    }
