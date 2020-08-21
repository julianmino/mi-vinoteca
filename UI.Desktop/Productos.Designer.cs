namespace UI.Desktop {
    partial class Productos {
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volalcoholDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añejamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yaguaronDBDataSet1 = new UI.Desktop.yaguaronDBDataSet1();
            this.productosTableAdapter = new UI.Desktop.yaguaronDBDataSet1TableAdapters.productosTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvProductos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.23952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.76048F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 334);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33223F));
            this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModificar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBorrar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(828, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(270, 55);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.Location = new System.Drawing.Point(279, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(269, 55);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBorrar.Location = new System.Drawing.Point(554, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(271, 55);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.mlDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.productorDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.volalcoholDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.añejamientoDataGridViewTextBoxColumn,
            this.ibuDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.productosBindingSource;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(828, 261);
            this.dgvProductos.TabIndex = 1;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mlDataGridViewTextBoxColumn
            // 
            this.mlDataGridViewTextBoxColumn.DataPropertyName = "ml";
            this.mlDataGridViewTextBoxColumn.HeaderText = "ml";
            this.mlDataGridViewTextBoxColumn.Name = "mlDataGridViewTextBoxColumn";
            this.mlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productorDataGridViewTextBoxColumn
            // 
            this.productorDataGridViewTextBoxColumn.DataPropertyName = "productor";
            this.productorDataGridViewTextBoxColumn.HeaderText = "productor";
            this.productorDataGridViewTextBoxColumn.Name = "productorDataGridViewTextBoxColumn";
            this.productorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // volalcoholDataGridViewTextBoxColumn
            // 
            this.volalcoholDataGridViewTextBoxColumn.DataPropertyName = "vol_alcohol";
            this.volalcoholDataGridViewTextBoxColumn.HeaderText = "vol_alcohol";
            this.volalcoholDataGridViewTextBoxColumn.Name = "volalcoholDataGridViewTextBoxColumn";
            this.volalcoholDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // añejamientoDataGridViewTextBoxColumn
            // 
            this.añejamientoDataGridViewTextBoxColumn.DataPropertyName = "añejamiento";
            this.añejamientoDataGridViewTextBoxColumn.HeaderText = "añejamiento";
            this.añejamientoDataGridViewTextBoxColumn.Name = "añejamientoDataGridViewTextBoxColumn";
            this.añejamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ibuDataGridViewTextBoxColumn
            // 
            this.ibuDataGridViewTextBoxColumn.DataPropertyName = "ibu";
            this.ibuDataGridViewTextBoxColumn.HeaderText = "ibu";
            this.ibuDataGridViewTextBoxColumn.Name = "ibuDataGridViewTextBoxColumn";
            this.ibuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.yaguaronDBDataSet1;
            // 
            // yaguaronDBDataSet1
            // 
            this.yaguaronDBDataSet1.DataSetName = "yaguaronDBDataSet1";
            this.yaguaronDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 334);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet1)).EndInit();
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private yaguaronDBDataSet1 yaguaronDBDataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private yaguaronDBDataSet1TableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volalcoholDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añejamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibuDataGridViewTextBoxColumn;
        }
    }