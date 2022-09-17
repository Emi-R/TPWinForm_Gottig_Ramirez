namespace TPWinForm_Gottig_Ramirez
{
    partial class frmArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblTituloArt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.gbxImagen = new System.Windows.Forms.GroupBox();
            this.pbxArt = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxFiltroRapido = new System.Windows.Forms.TextBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = "N/A";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.ColumnHeadersHeight = 34;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.NullValue = "N/A";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvArticulos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvArticulos.Location = new System.Drawing.Point(260, 151);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = "N/A";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = "N/A";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvArticulos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PowderBlue;
            this.dgvArticulos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.ShowEditingIcon = false;
            this.dgvArticulos.Size = new System.Drawing.Size(903, 538);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblTituloArt
            // 
            this.lblTituloArt.AutoSize = true;
            this.lblTituloArt.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArt.Location = new System.Drawing.Point(260, 74);
            this.lblTituloArt.Margin = new System.Windows.Forms.Padding(14);
            this.lblTituloArt.Name = "lblTituloArt";
            this.lblTituloArt.Size = new System.Drawing.Size(246, 68);
            this.lblTituloArt.TabIndex = 1;
            this.lblTituloArt.Text = "Articulos";
            this.lblTituloArt.Click += new System.EventHandler(this.lblTituloArt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1740, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menú";
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.BackColor = System.Drawing.Color.Honeydew;
            this.btnAgregarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArt.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAgregarArt.FlatAppearance.BorderSize = 3;
            this.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArt.Image")));
            this.btnAgregarArt.Location = new System.Drawing.Point(44, 222);
            this.btnAgregarArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(177, 106);
            this.btnAgregarArt.TabIndex = 3;
            this.btnAgregarArt.Text = "Agregar artículo";
            this.btnAgregarArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarArt.UseVisualStyleBackColor = false;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // gbxImagen
            // 
            this.gbxImagen.Controls.Add(this.pbxArt);
            this.gbxImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxImagen.Location = new System.Drawing.Point(1212, 151);
            this.gbxImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxImagen.Name = "gbxImagen";
            this.gbxImagen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxImagen.Size = new System.Drawing.Size(488, 468);
            this.gbxImagen.TabIndex = 4;
            this.gbxImagen.TabStop = false;
            // 
            // pbxArt
            // 
            this.pbxArt.Location = new System.Drawing.Point(9, 18);
            this.pbxArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxArt.Name = "pbxArt";
            this.pbxArt.Size = new System.Drawing.Size(470, 440);
            this.pbxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArt.TabIndex = 0;
            this.pbxArt.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Azure;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVolver.FlatAppearance.BorderSize = 3;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(44, 55);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 75);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModificarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarArt.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarArt.FlatAppearance.BorderSize = 3;
            this.btnModificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArt.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarArt.Image")));
            this.btnModificarArt.Location = new System.Drawing.Point(44, 391);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(177, 106);
            this.btnModificarArt.TabIndex = 6;
            this.btnModificarArt.Text = "Modificar Articulo";
            this.btnModificarArt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModificarArt.UseVisualStyleBackColor = false;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnEliminar.FlatAppearance.BorderSize = 3;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.Location = new System.Drawing.Point(44, 551);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 106);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Articulo";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxFiltroRapido);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(627, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Rápido (Codigo o Nombre)";
            // 
            // tbxFiltroRapido
            // 
            this.tbxFiltroRapido.Location = new System.Drawing.Point(7, 26);
            this.tbxFiltroRapido.Name = "tbxFiltroRapido";
            this.tbxFiltroRapido.Size = new System.Drawing.Size(2070, 44);
            this.tbxFiltroRapido.TabIndex = 0;
            this.tbxFiltroRapido.TextChanged += new System.EventHandler(this.tbxFiltroRapido_TextChanged);
            // 
            // cbxCampo
            // 
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(44, 66);
            this.cbxCampo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(235, 28);
            this.cbxCampo.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxCampo);
            this.groupBox2.Location = new System.Drawing.Point(260, 725);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(903, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro Avanzado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1740, 865);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxImagen);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.lblTituloArt);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblTituloArt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxImagen;
        private System.Windows.Forms.PictureBox pbxArt;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFiltroRapido;
    }
}