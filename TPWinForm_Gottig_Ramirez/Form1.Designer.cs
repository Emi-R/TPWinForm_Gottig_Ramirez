﻿namespace TPWinForm_Gottig_Ramirez
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnArticulos = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.gbxAbout = new System.Windows.Forms.GroupBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.Color.Black;
            this.btnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulos.Image")));
            this.btnArticulos.Location = new System.Drawing.Point(183, 418);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(206, 166);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(117, 152);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(656, 173);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Virtual Shop";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSubtitulo.Font = new System.Drawing.Font("Bahnschrift SemiLight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSubtitulo.Location = new System.Drawing.Point(302, 309);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(238, 39);
            this.lblSubtitulo.TabIndex = 4;
            this.lblSubtitulo.Text = "Menu Prinicipal";
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.Location = new System.Drawing.Point(474, 418);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(206, 166);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(474, 617);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(206, 166);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMarcas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.Black;
            this.btnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcas.Image")));
            this.btnMarcas.Location = new System.Drawing.Point(183, 617);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(206, 166);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMarcas.UseVisualStyleBackColor = false;
            // 
            // gbxAbout
            // 
            this.gbxAbout.Controls.Add(this.pictureBox1);
            this.gbxAbout.Controls.Add(this.lblAbout);
            this.gbxAbout.Location = new System.Drawing.Point(309, 791);
            this.gbxAbout.Name = "gbxAbout";
            this.gbxAbout.Size = new System.Drawing.Size(234, 38);
            this.gbxAbout.TabIndex = 5;
            this.gbxAbout.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAbout.Location = new System.Drawing.Point(104, 11);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(60, 23);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 862);
            this.Controls.Add(this.gbxAbout);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnArticulos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP WinForms / Gottig - Ramirez";
            this.gbxAbout.ResumeLayout(false);
            this.gbxAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.GroupBox gbxAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAbout;
    }
}

