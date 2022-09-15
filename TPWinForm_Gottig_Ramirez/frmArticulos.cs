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
    public partial class frmArticulos : Form
    {

        private List<Articulo> listaArt = new List<Articulo>();

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void cargarImagen(string img)
        {
            try
            {

                pbxArt.Load(img);

            }
            catch (Exception ex)
            {
                pbxArt.Load("https://budmil.at/files/system/no_image.png");
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio a = new ArticuloNegocio();


            try
            {
                listaArt = a.ListarArticulos();
                dgvArticulos.DataSource = listaArt;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;

                cargarImagen(listaArt[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            frmAgregarArt VentanaAgregarArt = new frmAgregarArt();
            VentanaAgregarArt.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo picked = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            cargarImagen(picked.ImagenUrl);
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {

        }
    }
}
