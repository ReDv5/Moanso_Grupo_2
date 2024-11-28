using CapaAccesoADatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton

         #region metodos
         ///listado
         public List<entProducto> ListarProducto()
         {
             return datProducto.Instancia.ListarProducto();
         }

         //Inserta

         public bool InsertaProducto(entProducto prod)
         {
             return datProducto.Instancia.InsertaProducto(prod);
         }

         public bool EditaProducto(entProducto prod)
         {
             return datProducto.Instancia.EditaProducto(prod);
         }

         #endregion 

    }
}
