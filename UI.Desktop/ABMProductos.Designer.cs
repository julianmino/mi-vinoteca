using System.Runtime.CompilerServices;

namespace UI.Desktop {
    partial class ABMProductos {
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProductor = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblAniejamiento = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblVolumenAlcohol = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.numAniejamiento = new System.Windows.Forms.NumericUpDown();
            this.numVolumenAlcohol = new System.Windows.Forms.NumericUpDown();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.lblMl = new System.Windows.Forms.Label();
            this.lblIBU = new System.Windows.Forms.Label();
            this.numIBU = new System.Windows.Forms.NumericUpDown();
            this.numMl = new System.Windows.Forms.NumericUpDown();
            this.cbProductor = new System.Windows.Forms.ComboBox();
            this.productoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yaguaronDBDataSet = new UI.Desktop.yaguaronDBDataSet();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pictBoxFoto = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.productoresTableAdapter = new UI.Desktop.yaguaronDBDataSetTableAdapters.productoresTableAdapter();
            this.fileDialogFoto = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAniejamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumenAlcohol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIBU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.Controls.Add(this.btnFoto, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lblProductor, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblStock, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblAniejamiento, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblAnio, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.lblVolumenAlcohol, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lblPrecio, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.numStock, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.numAniejamiento, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.numVolumenAlcohol, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.numPrecio, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.numAnio, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.lblMl, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.lblIBU, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.numIBU, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.numMl, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.cbProductor, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblFoto, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.pictBoxFoto, 3, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(489, 394);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoto.AutoSize = true;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFoto.Location = new System.Drawing.Point(247, 287);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(67, 29);
            this.btnFoto.TabIndex = 0;
            this.btnFoto.Text = "Abrir...";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(76, 11);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(165, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(76, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID Producto";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductor
            // 
            this.lblProductor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductor.AutoSize = true;
            this.lblProductor.Location = new System.Drawing.Point(3, 98);
            this.lblProductor.Name = "lblProductor";
            this.lblProductor.Size = new System.Drawing.Size(67, 13);
            this.lblProductor.TabIndex = 1;
            this.lblProductor.Text = "Productor";
            this.lblProductor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(3, 140);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(67, 13);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "Stock";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAniejamiento
            // 
            this.lblAniejamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAniejamiento.AutoSize = true;
            this.lblAniejamiento.Location = new System.Drawing.Point(3, 182);
            this.lblAniejamiento.Name = "lblAniejamiento";
            this.lblAniejamiento.Size = new System.Drawing.Size(67, 13);
            this.lblAniejamiento.TabIndex = 1;
            this.lblAniejamiento.Text = "Añejamiento";
            this.lblAniejamiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(247, 140);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(67, 13);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVolumenAlcohol
            // 
            this.lblVolumenAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumenAlcohol.AutoSize = true;
            this.lblVolumenAlcohol.Location = new System.Drawing.Point(247, 14);
            this.lblVolumenAlcohol.Name = "lblVolumenAlcohol";
            this.lblVolumenAlcohol.Size = new System.Drawing.Size(67, 13);
            this.lblVolumenAlcohol.TabIndex = 1;
            this.lblVolumenAlcohol.Text = "% Alcohol";
            this.lblVolumenAlcohol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(247, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(67, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio   $";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numStock
            // 
            this.numStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numStock.Location = new System.Drawing.Point(76, 137);
            this.numStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(165, 20);
            this.numStock.TabIndex = 3;
            this.numStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAniejamiento
            // 
            this.numAniejamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numAniejamiento.Location = new System.Drawing.Point(76, 179);
            this.numAniejamiento.Name = "numAniejamiento";
            this.numAniejamiento.Size = new System.Drawing.Size(165, 20);
            this.numAniejamiento.TabIndex = 4;
            this.numAniejamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numVolumenAlcohol
            // 
            this.numVolumenAlcohol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numVolumenAlcohol.Location = new System.Drawing.Point(320, 11);
            this.numVolumenAlcohol.Name = "numVolumenAlcohol";
            this.numVolumenAlcohol.Size = new System.Drawing.Size(166, 20);
            this.numVolumenAlcohol.TabIndex = 5;
            this.numVolumenAlcohol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPrecio
            // 
            this.numPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Location = new System.Drawing.Point(320, 95);
            this.numPrecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(166, 20);
            this.numPrecio.TabIndex = 7;
            this.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAnio
            // 
            this.numAnio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numAnio.Location = new System.Drawing.Point(320, 137);
            this.numAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numAnio.Minimum = new decimal(new int[] {
            1945,
            0,
            0,
            0});
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(166, 20);
            this.numAnio.TabIndex = 8;
            this.numAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAnio.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // lblMl
            // 
            this.lblMl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMl.AutoSize = true;
            this.lblMl.Location = new System.Drawing.Point(247, 56);
            this.lblMl.Name = "lblMl";
            this.lblMl.Size = new System.Drawing.Size(67, 13);
            this.lblMl.TabIndex = 1;
            this.lblMl.Text = "ml";
            this.lblMl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIBU
            // 
            this.lblIBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIBU.AutoSize = true;
            this.lblIBU.Location = new System.Drawing.Point(247, 182);
            this.lblIBU.Name = "lblIBU";
            this.lblIBU.Size = new System.Drawing.Size(67, 13);
            this.lblIBU.TabIndex = 1;
            this.lblIBU.Text = "IBU";
            this.lblIBU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numIBU
            // 
            this.numIBU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numIBU.Location = new System.Drawing.Point(320, 179);
            this.numIBU.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numIBU.Name = "numIBU";
            this.numIBU.Size = new System.Drawing.Size(166, 20);
            this.numIBU.TabIndex = 6;
            this.numIBU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numMl
            // 
            this.numMl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numMl.Location = new System.Drawing.Point(320, 53);
            this.numMl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMl.Name = "numMl";
            this.numMl.Size = new System.Drawing.Size(166, 20);
            this.numMl.TabIndex = 9;
            this.numMl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbProductor
            // 
            this.cbProductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProductor.DataSource = this.productoresBindingSource;
            this.cbProductor.DisplayMember = "nombre";
            this.cbProductor.FormattingEnabled = true;
            this.cbProductor.Location = new System.Drawing.Point(76, 94);
            this.cbProductor.Name = "cbProductor";
            this.cbProductor.Size = new System.Drawing.Size(164, 21);
            this.cbProductor.TabIndex = 10;
            this.cbProductor.ValueMember = "id_productor";
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
            // lblFoto
            // 
            this.lblFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFoto.Location = new System.Drawing.Point(76, 293);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(165, 17);
            this.lblFoto.TabIndex = 1;
            this.lblFoto.Text = "Cargar Foto";
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictBoxFoto
            // 
            this.pictBoxFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBoxFoto.Location = new System.Drawing.Point(320, 213);
            this.pictBoxFoto.Name = "pictBoxFoto";
            this.pictBoxFoto.Size = new System.Drawing.Size(166, 178);
            this.pictBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxFoto.TabIndex = 11;
            this.pictBoxFoto.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Size = new System.Drawing.Size(489, 470);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Location = new System.Drawing.Point(222, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 57);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(380, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 56);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // productoresTableAdapter
            // 
            this.productoresTableAdapter.ClearBeforeFill = true;
            // 
            // fileDialogFoto
            // 
            this.fileDialogFoto.FileName = "foto";
            this.fileDialogFoto.Filter = "JPG File|*.jpg|PNG File|*.png|JPEG File|*.jpeg";
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 470);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ABMProductos";
            this.Text = "ABMProductos";
            this.Load += new System.EventHandler(this.ABMProductos_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAniejamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolumenAlcohol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIBU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaguaronDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxFoto)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProductor;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblAniejamiento;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblIBU;
        private System.Windows.Forms.Label lblVolumenAlcohol;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.NumericUpDown numAniejamiento;
        private System.Windows.Forms.NumericUpDown numVolumenAlcohol;
        private System.Windows.Forms.NumericUpDown numIBU;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.Label lblMl;
        private System.Windows.Forms.NumericUpDown numMl;
        private System.Windows.Forms.ComboBox cbProductor;
        private yaguaronDBDataSet yaguaronDBDataSet;
        private System.Windows.Forms.BindingSource productoresBindingSource;
        private yaguaronDBDataSetTableAdapters.productoresTableAdapter productoresTableAdapter;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.OpenFileDialog fileDialogFoto;
        private System.Windows.Forms.PictureBox pictBoxFoto;
        }
    }