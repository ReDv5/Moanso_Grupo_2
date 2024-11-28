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
    public class datProducto
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instanciación directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Proveedor
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto prod = new entProducto();
                    prod.producto_id = Convert.ToInt32(dr["producto_id"]);
                    prod.nombre = dr["nombre"].ToString();
                    prod.descirpcion = dr["descripcion"].ToString();
                    prod.precio_unidad = Convert.ToDouble(dr["precio_unidad"]);
                    prod.estado = dr["estado"].ToString();
                    prod.categoria_id = Convert.ToInt32(dr["producto_id"]);
                    lista.Add(prod);
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

        /////////////////////////InsertaProducto
        public Boolean InsertaProducto(entProducto prod)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", prod.nombre);
                cmd.Parameters.AddWithValue("@descripcion", prod.descirpcion);
                cmd.Parameters.AddWithValue("@precio_unidad", prod.precio_unidad);
                cmd.Parameters.AddWithValue("@estado", prod.estado);

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
        //Edita Producto
        public bool EditaProducto(entProducto prod)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@producto_id", prod.producto_id);
                cmd.Parameters.AddWithValue("@nombre", prod.nombre);
                cmd.Parameters.AddWithValue("@descripcion", prod.descirpcion);
                cmd.Parameters.AddWithValue("@precio_unidad", prod.precio_unidad);
                cmd.Parameters.AddWithValue("@estado", prod.estado);
                cmd.Parameters.AddWithValue("@categoria_id", prod.categoria_id);
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

