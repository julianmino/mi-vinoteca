namespace UI.Desktop
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.iconMinimize = new System.Windows.Forms.PictureBox();
            this.iconShrink = new System.Windows.Forms.PictureBox();
            this.iconMaximize = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconShrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.Firebrick;
            this.menuVertical.Controls.Add(this.label1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 650);
            this.menuVertical.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VINOTECA YAGUARÓN";
            // 
            // btnSlide
            // 
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.iconMinimize);
            this.panelTitulo.Controls.Add(this.iconShrink);
            this.panelTitulo.Controls.Add(this.iconMaximize);
            this.panelTitulo.Controls.Add(this.iconClose);
            this.panelTitulo.Controls.Add(this.btnSlide);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(250, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1050, 50);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // iconMinimize
            // 
            this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimize.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimize.Image")));
            this.iconMinimize.Location = new System.Drawing.Point(960, 3);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(25, 25);
            this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimize.TabIndex = 2;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // iconShrink
            // 
            this.iconShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconShrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconShrink.Image = ((System.Drawing.Image)(resources.GetObject("iconShrink.Image")));
            this.iconShrink.Location = new System.Drawing.Point(991, 3);
            this.iconShrink.Name = "iconShrink";
            this.iconShrink.Size = new System.Drawing.Size(25, 25);
            this.iconShrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconShrink.TabIndex = 1;
            this.iconShrink.TabStop = false;
            this.iconShrink.Visible = false;
            this.iconShrink.Click += new System.EventHandler(this.iconShrink_Click);
            // 
            // iconMaximize
            // 
            this.iconMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximize.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximize.Image")));
            this.iconMaximize.Location = new System.Drawing.Point(991, 3);
            this.iconMaximize.Name = "iconMaximize";
            this.iconMaximize.Size = new System.Drawing.Size(25, 25);
            this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximize.TabIndex = 1;
            this.iconMaximize.TabStop = false;
            this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1022, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(25, 25);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 0;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 2;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconShrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox iconMinimize;
        private System.Windows.Forms.PictureBox iconShrink;
        private System.Windows.Forms.PictureBox iconMaximize;
        private System.Windows.Forms.PictureBox iconClose;
    }
}