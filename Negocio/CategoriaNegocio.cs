using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class CategoriaNegocio
    {
        AccesoDatos db = new AccesoDatos();

        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            string consulta = "Select C.Id, C.Descripcion From CATEGORIAS C";
            db.SetearConsulta(consulta);
            db.EjecutarLectura();

            try 
            {
                while (db.Reader.Read())
                {
                    Categoria cat = new Categoria();

                    cat.ID = db.Reader.GetInt32(0);
                    cat.Descripcion = db.Reader.GetString(1);

                    lista.Add(cat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                db.CerrarConexion();
            }

            return lista;
        }
    }
}
