namespace TPWinForm_Gottig_Ramirez
{
    partial class frmAgregarArt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArt));
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbxDesc = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbVistaPrevia = new System.Windows.Forms.GroupBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbVistaPrevia.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregar.Location = new System.Drawing.Point(298, 27);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(149, 25);
            this.lblTituloAgregar.TabIndex = 0;
            this.lblTituloAgregar.Text = "Artículo nuevo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(46, 82);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(99, 79);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(72, 20);
            this.tbxCodigo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(177, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(230, 79);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(167, 20);
            this.tbxNombre.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(24, 116);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(69, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Descripción: ";
            // 
            // tbxDesc
            // 
            this.tbxDesc.Location = new System.Drawing.Point(99, 113);
            this.tbxDesc.Multiline = true;
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Size = new System.Drawing.Size(298, 73);
            this.tbxDesc.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(46, 200);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca: ";
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(99, 197);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(146, 21);
            this.cbxMarcas.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(34, 233);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(99, 230);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(146, 21);
            this.cbxCategoria.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // gpbVistaPrevia
            // 
            this.gpbVistaPrevia.Controls.Add(this.pictureBox1);
            this.gpbVistaPrevia.Location = new System.Drawing.Point(425, 72);
            this.gpbVistaPrevia.Name = "gpbVistaPrevia";
            this.gpbVistaPrevia.Size = new System.Drawing.Size(318, 239);
            this.gpbVistaPrevia.TabIndex = 13;
            this.gpbVistaPrevia.TabStop = false;
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.BackColor = System.Drawing.SystemColors.Control;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.Location = new System.Drawing.Point(532, 314);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(101, 13);
            this.lblVistaPrevia.TabIndex = 12;
            this.lblVistaPrevia.Text = "Vista Previa Imagen";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(44, 265);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 14;
            this.lblImagen.Text = "Imagen:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 15;
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarImg.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarImg.Image")));
            this.btnCargarImg.Location = new System.Drawing.Point(365, 262);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(32, 20);
            this.btnCargarImg.TabIndex = 16;
            this.btnCargarImg.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(49, 295);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio:";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(99, 291);
            this.textBox2.MaxLength = 7;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Tag = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(273, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 41);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(99, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 41);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAgregarArt
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(763, 395);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnCargarImg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.gpbVistaPrevia);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTituloAgregar);
            this.Name = "frmAgregarArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregarArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbVistaPrevia.ResumeLayout(false);
            this.gpbVistaPrevia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox tbxDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbVistaPrevia;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCargarImg;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}