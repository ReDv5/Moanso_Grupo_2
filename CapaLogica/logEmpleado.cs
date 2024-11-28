using System;
using System.Collections.Generic;
using CapaEntidad;
using CapaAccesoADatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logEmpleado
    {
        #region Singleton
        private static readonly logEmpleado _instancia = new logEmpleado();
        public static logEmpleado Instancia
        {
            get
            {
                return logEmpleado._instancia;
            }
        }
        #endregion

        #region Métodos

        // Listar empleados
        public List<entEmpleado> ListarEmpleado()
        {
            try
            {
                return datEmpleado.Instancia.ListarEmpleado();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Agregar empleado
        public bool InsertaEmpleado(entEmpleado emp)
        {
            try
            {
                return datEmpleado.Instancia.InsertaEmpleado(emp);
            }
            catch (Exception e)
            {
                throw e; // Lanza la excepción para que pueda ser rastreada
            }
        }

        // Modificar empleado
        public bool EditaEmpleado(entEmpleado emp)
        {
            try
            {
                return datEmpleado.Instancia.EditaEmpleado(emp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion



    }
}
