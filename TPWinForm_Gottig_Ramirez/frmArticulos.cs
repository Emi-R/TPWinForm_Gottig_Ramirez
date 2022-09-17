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
            catch (Exception)
            {
                pbxArt.Load("https://media.istockphoto.com/vectors/no-image-vector-symbol-missing-available-icon-no-gallery-for-this-vector-id1128826884?k=20&m=1128826884&s=170667a&w=0&h=_cx7HW9R4Uc_OLLxg2PcRXno4KERpYLi5vCz-NEyhi0=");
            }
        }

        private void updateGrilla()
        {
            ArticuloNegocio a = new ArticuloNegocio();

            try
            {
                listaArt = a.ListarArticulos();
                dgvArticulos.DataSource = listaArt;
                ocultarColumnas();
                cargarImagen(listaArt[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            //TODO: Poner Precio debajo de la imagen
            updateGrilla();

            cbxCampo.Items.Add("Código");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoría");
            cbxCampo.Items.Add("Precio");

            cbxCampo.SelectedIndex = 0;

            cbxCriterio.SelectedIndex = 0;

        }


        //Boton Agregar Articulo

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            frmAgregarArt VentanaAgregarArt = new frmAgregarArt();
            VentanaAgregarArt.ShowDialog();
            updateGrilla();
        }

        //Boton Modificar Articulo

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArt formModificar = new frmAgregarArt(articulo);
            formModificar.ShowDialog();
            updateGrilla();
        }

        //Boton Eliminar Articulo

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo picked = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            string mensaje = $"Desea eliminar el articulo {picked.Codigo}?";
            string title = "Confirmar borrado";

            DialogResult msg = MessageBox.Show(mensaje, title, buttons, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();

                try
                {
                    articuloNegocio.EliminarArticulo(picked);
                    updateGrilla();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                return;
            }
        }

        //Boton Volver A Menu

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo picked = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(picked.ImagenUrl);
            }
        }

        private void tbxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltroRapido;
            string filtro = tbxFiltroRapido.Text;

            if (filtro.Length >= 3)
            {
                listaFiltroRapido = listaArt.FindAll(a => a.Nombre.ToUpper().Contains(tbxFiltroRapido.Text.ToUpper()));
            }
            else
            {
                listaFiltroRapido = listaArt;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltroRapido;

            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string opc = cbxCampo.SelectedItem.ToString();

            switch (opc)
            {
                case "Código":
                case "Nombre":
                case "Marca":
                case "Categoría":
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Comienza con");
                    cbxCriterio.Items.Add("Contiene");
                    cbxCriterio.Items.Add("Finaliza con");
                    break;
                case "Precio":
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Menor a");
                    cbxCriterio.Items.Add("Igual a");
                    cbxCriterio.Items.Add("Mayor a");
                    break;
            }

            cbxCriterio.SelectedIndex = 0;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if(txtFiltro.Text == "")
                {
                    MessageBox.Show("Campo filtro esta vacio.");
                    return;
                }

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                int ordenarPor = 0;

                if (rbtAsc.Checked == true)
                    ordenarPor = 2;

                if (rbtDesc.Checked == true)
                    ordenarPor = 1;

                dgvArticulos.DataSource = articuloNegocio.Filtrar(campo, criterio, filtro, ordenarPor);
                ocultarColumnas();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            updateGrilla();
            txtFiltro.Clear();
        }
    }
}
