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
    public class datEmpleado
    {

        #region Singleton
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion

        #region Métodos

        // Método para listar empleados
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // Singleton
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entEmpleado emp = new entEmpleado
                    {
                        empleado_id = Convert.ToInt32(dr["empleado_id"]),
                        nombre = dr["nombre"].ToString(),
                        apellido = dr["apellido"].ToString(),
                        telefono = Convert.ToInt32(dr["telefono"]),
                        contacto = dr["contacto"].ToString(),
                        estado = dr["estado"].ToString(),
                        rol_id = Convert.ToInt32(dr["rol_id"]),
                        tienda_id = Convert.ToInt32(dr["tienda_id"])
                    };
                    lista.Add(emp);
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

        // Método para agregar un empleado
        public bool InsertaEmpleado(entEmpleado emp)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAgregarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", emp.nombre);
                cmd.Parameters.AddWithValue("@apellido", emp.apellido);
                cmd.Parameters.AddWithValue("@telefono", emp.telefono);
                cmd.Parameters.AddWithValue("@contacto", emp.contacto);
                cmd.Parameters.AddWithValue("@estado", emp.estado);
                cmd.Parameters.AddWithValue("@rol_id", emp.rol_id);
                cmd.Parameters.AddWithValue("@tienda_id", emp.tienda_id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                inserta = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserta;
        }

        // Método para editar un empleado
        public bool EditaEmpleado(entEmpleado emp)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empleado_id", emp.empleado_id);
                cmd.Parameters.AddWithValue("@nombre", emp.nombre);
                cmd.Parameters.AddWithValue("@apellido", emp.apellido);
                cmd.Parameters.AddWithValue("@telefono", emp.telefono);
                cmd.Parameters.AddWithValue("@contacto", emp.contacto);
                cmd.Parameters.AddWithValue("@estado", emp.estado);
                cmd.Parameters.AddWithValue("@rol_id", emp.rol_id);
                cmd.Parameters.AddWithValue("@tienda_id", emp.tienda_id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                edita = (i > 0);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        #endregion


    }
}
