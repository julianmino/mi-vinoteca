using System;
using Business.Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop {
    public partial class Productores : Form {
        public Productores() {
            InitializeComponent();
            dgvProductores.AutoGenerateColumns = false;

            }

        private void Productores_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'yaguaronDBDataSet.productores' table. You can move, or remove it, as needed.
            this.productoresTableAdapter.Fill(this.yaguaronDBDataSet.productores);
            Listar();

            }
        public void Listar() {
            ProductorLogic prodLog = new ProductorLogic();
            dgvProductores.DataSource = prodLog.GetAll();
            }
        private int GetId() {
           
            return int.Parse(dgvProductores.Rows[dgvProductores.CurrentRow.Index].Cells[0].Value.ToString());
                
            }
        private void btnAgregar_Click(object sender, EventArgs e) {
            ABMProductores productor = new ABMProductores(ApplicationForm.ModoForm.Alta);
            productor.ShowDialog();
            this.Listar();
            }

        private void btnModificar_Click(object sender, EventArgs e) {
            int id_productor = GetId();
            
            ABMProductores productor = new ABMProductores(ApplicationForm.ModoForm.Modificacion, id_productor);
            productor.ShowDialog();
            this.Listar();
                
            }

        private void btnBorrar_Click(object sender, EventArgs e) {
            int id_productor = GetId();
            
            ABMProductores productor = new ABMProductores(ApplicationForm.ModoForm.Baja, id_productor);
            productor.ShowDialog();
            this.Listar();
                
            }
        }
    }
