using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoADatos
{
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Proveedor
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor proveedor = new entProveedor();
                    proveedor.proveedor_id = Convert.ToInt32(dr["proveedor_id"]);
                    proveedor.nombre = dr["nombre"].ToString();
                    proveedor.contacto = dr["contacto"].ToString();
                    proveedor.telefono = Convert.ToInt32(dr["telefono"]);
                    proveedor.direccion = dr["direccion"].ToString();
                    proveedor.estado = dr["producto_id"].ToString();
                    lista.Add(proveedor);
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

        /////////////////////////InsertaProveedor
        public Boolean InsertaProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", proveedor.nombre);
                cmd.Parameters.AddWithValue("@contacto", proveedor.contacto);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                cmd.Parameters.AddWithValue("@direccion", proveedor.direccion);
                cmd.Parameters.AddWithValue("@estado", proveedor.estado);
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

        public bool EditaProveedor(entProveedor proveedor)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proveedor_id", proveedor.proveedor_id);
                cmd.Parameters.AddWithValue("@nombre", proveedor.nombre);
                cmd.Parameters.AddWithValue("@contacto", proveedor.contacto);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                cmd.Parameters.AddWithValue("@direccion", proveedor.direccion);
                cmd.Parameters.AddWithValue("@estado", proveedor.estado);
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




