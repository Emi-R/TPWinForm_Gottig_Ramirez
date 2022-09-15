using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos db = new AccesoDatos();

        public List<Articulo> ListarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            string consulta = "SELECT A.ID AS ID, A.CODIGO AS CODIGO, A.NOMBRE AS NOMBRE, A.DESCRIPCION AS DESCRIPCION, M.Descripcion AS MARCA, C.Descripcion AS CATEGORIA, A.IMAGENURL AS IMAGENURL, A.Precio FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
            db.SetearConsulta(consulta);
            db.EjecutarLectura();

            try
            {
                while (db.Reader.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)db.Reader["ID"];
                    articulo.Codigo = (string)db.Reader["Codigo"];
                    articulo.Nombre = (string)db.Reader["Nombre"];
                    articulo.Descripcion = (string)db.Reader["Descripcion"];

                    articulo.Marca = new Marca();

                    //if (!(db.Reader["Marca"] is DBNull))
                        articulo.Marca.Descripcion = (string)db.Reader["Marca"];

                    //if (!(db.Reader["Categoria"] is DBNull))
                        articulo.Categoria = new Categoria();

                    articulo.Categoria.Descripcion = (string)db.Reader["Categoria"];
                    articulo.ImagenUrl = (string)db.Reader["ImagenUrl"];
                    articulo.Precio = (float)db.Reader.GetDecimal(7);

                    articulos.Add(articulo);
                }

                return articulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                db.CerrarConexion();
            }

        }

        public void AgregarArticulo(Articulo nuevo)
        {
            try
            {
                db.SetearParametro("@IdMarca", nuevo.Marca.ID);
                db.SetearParametro("@IdCategoria", nuevo.Categoria.ID);

                string Consulta = $"Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values ('{nuevo.Codigo}', '{nuevo.Nombre}', '{nuevo.Descripcion}', @IdMarca, @IdCategoria, '{nuevo.ImagenUrl}',  {nuevo.Precio})";

                db.SetearConsulta(Consulta);
                db.EjecutarAccion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        public void ModificarArticulo(Articulo articulo)
        {
            try
            {
                string consulta = $"UPDATE ARTICULOS SET CODIGO = {articulo.Codigo}, NOMBRE = '{articulo.Nombre}', Descripcion ='{articulo.Descripcion}', IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl = '{articulo.ImagenUrl}', PRECIO = {articulo.Precio} WHERE ID = {articulo.Id}";
                db.SetearConsulta(consulta);

                db.SetearParametro("@IdMarca", articulo.Marca.ID);
                db.SetearParametro("@IdCategoria", articulo.Categoria.ID);

                db.EjecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                db.CerrarConexion();
            }
        }
    }
}
