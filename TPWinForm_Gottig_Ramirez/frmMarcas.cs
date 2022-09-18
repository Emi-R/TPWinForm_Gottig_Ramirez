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
    public partial class frmMarcas : Form
    {
        private List<Marca> listadoMarcas;
        private MarcaNegocio negocioMarca = new MarcaNegocio();
        public frmMarcas()
        {
            InitializeComponent();
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            updateGrilla();
        }
        private void updateGrilla()
        {
            try
            {
                listadoMarcas = negocioMarca.listar();
                dgvMarcas.DataSource = listadoMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void filtrar()
        {
            List<Marca> listaFilrada = new List<Marca>();
            string filtro = tbxFiltro.Text;

            if(filtro != null)
            {
                listaFilrada = listadoMarcas.FindAll(m => m.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFilrada = listadoMarcas;
            }
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFilrada;
        }
        private void tbxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                filtrar();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca frmAgregarMarca = new frmAgregarMarca();
            frmAgregarMarca.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAgregarMarca frmModificarMarca = new frmAgregarMarca();
            frmModificarMarca.ShowDialog();
        }
    }
}
