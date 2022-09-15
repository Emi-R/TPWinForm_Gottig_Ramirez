using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Gottig_Ramirez
{
    public partial class frmAgregarArt : Form
    {
        public frmAgregarArt()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            AccesoDatos db = new AccesoDatos();

            Articulo nuevo = new Articulo();

            try
            {
                nuevo.Codigo = tbxCodigo.Text;
                nuevo.Nombre = tbxNombre.Text;
                nuevo.Descripcion = tbxDesc.Text;

                nuevo.Marca = new Marca();
                nuevo.Marca = (Marca)cbxMarcas.SelectedItem;

                nuevo.Categoria = new Categoria();
                nuevo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                nuevo.ImagenUrl = tbxImagenUrl.Text;
                nuevo.Precio = int.Parse(tbxPrecio.Text);

                db.SetearParametro("@IdMarca", nuevo.Marca.ID);
                db.SetearParametro("@IdCategoria", nuevo.Categoria.ID);

                string Consulta = $"Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values ('{nuevo.Codigo}', '{nuevo.Nombre}', '{nuevo.Descripcion}', @IdMarca, @IdCategoria, '{nuevo.ImagenUrl}',  {nuevo.Precio})";

                db.SetearConsulta(Consulta);
                db.EjecutarAccion();

                MessageBox.Show("Articulo agregado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        private void frmAgregarArt_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarcas.DataSource = marcaNegocio.listar();

            CategoriaNegocio catNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = catNegocio.listar();
        }
    }
}
