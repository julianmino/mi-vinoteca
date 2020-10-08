namespace UI.Desktop {
    partial class Productores {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProductores = new System.Windows.Forms.DataGridView();
            this.idproductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yaguaronDBDataSet = new UI.Desktop.yaguaronDBDataSet();
            this.productoresTableAdapter = new UI.Desktop.yaguaronDBDataSetTableAdapters.productoresTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvProductores, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.36257F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.63743F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel2.Controls.Add(this.btnBorrar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 158);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrar.Location = new System.Drawing.Point(198, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 31);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.Location = new System.Drawing.Point(101, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 31);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProductores
            // 
            this.dgvProductores.AutoGenerateColumns = false;
            this.dgvProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgvProductores.DataSource = this.productoresBindingSource;
            this.dgvProductores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductores.Location = new System.Drawing.Point(3, 3);
            this.dgvProductores.Name = "dgvProductores";
            this.dgvProductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductores.Size = new System.Drawing.Size(294, 149);
            this.dgvProductores.TabIndex = 1;
            // 
            // idproductorDataGridViewTextBoxColumn
            // 
            this.idproductorDataGridViewTextBoxColumn.DataPropertyName = "id_productor";
            this.idproductorDataGridViewTextBoxColumn.HeaderText = "id_productor";
            this.idproductorDataGridViewTextBoxColumn.Name = "idproductorDataGridViewTextBoxColumn";
            this.idproductorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // productoresBindingSource
            // 
            this.productoresBindingSource.DataMember = "productores";
            this.productoresBindingSource.DataSource = this.yaguaronDBDataSet;
            // 
            // yaguaronDBDataSet
            // 
            this.yaguaronDBDataSet.DataSetName = "yaguaronDBDataSet";
            this.yaguaronDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoresTableAdapter
            // 
            this.productoresTableAdapter.ClearBeforeFill = true;
            // 
            // Productores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 198);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Productores";
            this.Text = "Productores";
            this.Load += new System.EventHandler(this.Productores_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvProductores;
        private yaguaronDBDataSet yaguaronDBDataSet;
        private System.Windows.Forms.BindingSource productoresBindingSource;
        private yaguaronDBDataSetTableAdapters.productoresTableAdapter productoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        }
    }