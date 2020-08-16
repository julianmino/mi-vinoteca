namespace UI.Desktop
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yaguaronDBDataSet = new UI.Desktop.yaguaronDBDataSet();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new UI.Desktop.yaguaronDBDataSetTableAdapters.clientesTableAdapter();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premiumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iddescuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvClientes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(831, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.Controls.Add(this.btnBorrar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 427);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(825, 69);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrar.Location = new System.Drawing.Point(555, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(267, 63);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.Location = new System.Drawing.Point(275, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(274, 63);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(266, 63);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclienteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.fechanacDataGridViewTextBoxColumn,
            this.premiumDataGridViewCheckBoxColumn,
            this.iddescuentoDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvClientes, 2);
            this.dgvClientes.DataSource = this.clientesBindingSource2;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(825, 418);
            this.dgvClientes.TabIndex = 0;
            // 
            // yaguaronDBDataSet
            // 
            this.yaguaronDBDataSet.DataSetName = "yaguaronDBDataSet";
            this.yaguaronDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "clientes";
            this.clientesBindingSource2.DataSource = this.yaguaronDBDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            this.claveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechanacDataGridViewTextBoxColumn
            // 
            this.fechanacDataGridViewTextBoxColumn.DataPropertyName = "fecha_nac";
            this.fechanacDataGridViewTextBoxColumn.HeaderText = "fecha_nac";
            this.fechanacDataGridViewTextBoxColumn.Name = "fechanacDataGridViewTextBoxColumn";
            this.fechanacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // premiumDataGridViewCheckBoxColumn
            // 
            this.premiumDataGridViewCheckBoxColumn.DataPropertyName = "premium";
            this.premiumDataGridViewCheckBoxColumn.HeaderText = "premium";
            this.premiumDataGridViewCheckBoxColumn.Name = "premiumDataGridViewCheckBoxColumn";
            this.premiumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // iddescuentoDataGridViewTextBoxColumn
            // 
            this.iddescuentoDataGridViewTextBoxColumn.DataPropertyName = "id_descuento";
            this.iddescuentoDataGridViewTextBoxColumn.HeaderText = "id_descuento";
            this.iddescuentoDataGridViewTextBoxColumn.Name = "iddescuentoDataGridViewTextBoxColumn";
            this.iddescuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private yaguaronDBDataSet yaguaronDBDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private yaguaronDBDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn premiumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddescuentoDataGridViewTextBoxColumn;
    }
}