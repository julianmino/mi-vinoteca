using Business.Logic;
using System;

namespace UI.Desktop {
    public partial class Productos : ApplicationForm {

        public Productos(TipoForm tipo) {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;

            switch (tipo) {
                case TipoForm.Vino : Id_tipo = 0; break;
                case TipoForm.Cerveza : Id_tipo = 1; break;
                case TipoForm.Licor : Id_tipo = 2; break;
                case TipoForm.Whisky : Id_tipo = 3; break;
                }
            }
        public enum TipoForm {
            Vino,
            Cerveza,
            Licor,
            Whisky
            }

        private TipoForm _Tipo;
        public TipoForm Tipo { get => _Tipo; set => _Tipo = value; }
        private int _id_tipo;
        public int Id_tipo { get => _id_tipo; set => _id_tipo = value; }

        private void Productos_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.yaguaronDBDataSet.productos);
            Listar();
            }
        public void Listar() {
            ProductoLogic prodLog = new ProductoLogic();
            dgvProductos.DataSource = prodLog.GetProductoPorTipo(Id_tipo);
            }
        private int? GetId() {
            try {
                return int.Parse(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                }
            catch {
                return null;
                }
            }
        private void btnAgregar_Click(object sender, EventArgs e) {
            ABMProductos producto = new ABMProductos(ApplicationForm.ModoForm.Alta, this.Id_tipo);
            producto.ShowDialog();
            this.Listar();
            }             

        private void btnModificar_Click(object sender, EventArgs e) {
            int? id = GetId();            

            if (id != null) {
                ABMProductos producto = new ABMProductos(ApplicationForm.ModoForm.Modificacion,this.Id_tipo, id);
                producto.ShowDialog();
                this.Listar();
                }
            }

        private void btnBorrar_Click(object sender, EventArgs e) {
            int? id = GetId();
            if (id != null) {
                ABMProductos producto = new ABMProductos(ApplicationForm.ModoForm.Baja,this.Id_tipo, id);
                producto.ShowDialog();
                this.Listar();
                }
            }
        }
    }
