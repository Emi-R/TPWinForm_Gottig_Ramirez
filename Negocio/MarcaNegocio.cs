using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class MarcaNegocio
    {
        AccesoDatos db = new AccesoDatos();

        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();

            string consulta = "Select M.Id, M.Descripcion From MARCAS M";

            try
            {
                db.SetearConsulta(consulta);
                db.EjecutarLectura();

                while (db.Reader.Read())
                {
                    Marca marca = new Marca();

                    marca.ID = db.Reader.GetInt32(0);
                    marca.Descripcion = db.Reader.GetString(1);

                    lista.Add(marca);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            finally
            {
                db.CerrarConexion();
            }

            return lista;
        }

        public void AgregarMarca()
        {

        }

        public void ModificarMarca()
        {

        }
    }
}
