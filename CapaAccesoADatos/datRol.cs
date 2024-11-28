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
    public class datRol
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datRol _instancia = new datRol();
        //privado para evitar la instanciación directa
        public static datRol Instancia
        {
            get
            {
                return datRol._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Rol
        public List<entRol> ListarRol()
        {
            SqlCommand cmd = null;
            List<entRol> lista = new List<entRol>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRol Rol = new entRol();
                    Rol.rol_id = Convert.ToInt32(dr["rol_id"]);
                    Rol.nombre = dr["nombre"].ToString();
                    lista.Add(Rol);
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

        /////////////////////////InsertaRol
        public Boolean InsertaRol(entRol Rol)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Rol.nombre);
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
        //Edita rol
        public bool EditaRol(entRol Rol)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rol_id", Rol.rol_id);
                cmd.Parameters.AddWithValue("@nombre", Rol.nombre);
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
