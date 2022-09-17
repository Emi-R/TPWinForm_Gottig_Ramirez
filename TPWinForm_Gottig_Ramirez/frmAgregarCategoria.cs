using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Gottig_Ramirez
{
    public partial class frmAgregarCategoria : Form
    {
        private Categoria categoria = null;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        public frmAgregarCategoria(Categoria categoria)
        {
            this.categoria = categoria;
            
            InitializeComponent();
            
        }
        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            btnAgregar.Text = "Modificar categoria";

            //TODO: Checkear si es NULL para agregar/modificar
            lblCategorias.Text = $"Categoria: {categoria.Descripcion}";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
