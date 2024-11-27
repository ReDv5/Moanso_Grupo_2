using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaAccesoADatos
{
    public class datTienda
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datTienda _instancia = new datTienda();
        //privado para evitar la instanciación directa
        public static datTienda Instancia
        {
            get
            {
                return datTienda._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Tienda
        public List<entTienda> ListarTiendal()
        {
            SqlCommand cmd = null;
            List<entTienda> lista = new List<entTienda>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTienda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTienda t = new entTienda();
                    t.tienda_id = Convert.ToInt32(dr["tienda_id"]);
                    t.nombre = dr["nombre"].ToString();
                    t.ubicacion = dr["ubicacion"].ToString();
                    lista.Add(t);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        /////////////////////////Inserta Tienda
        public Boolean InsertaTienda(entTienda t)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarTienda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", t.nombre);
                cmd.Parameters.AddWithValue("@ubicacion", t.ubicacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        //Edita Tienda
        public bool EditaTienda(entTienda t)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaTienda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tienda_id", t.tienda_id);
                cmd.Parameters.AddWithValue("@nombre", t.nombre);
                cmd.Parameters.AddWithValue("@ubicacion", t.ubicacion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }




        #endregion metodos
    }
}
