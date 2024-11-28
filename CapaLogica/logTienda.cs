using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoADatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTienda
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTienda _instancia = new logTienda();
        //privado para evitar la instanciación directa
        public static logTienda Instancia
        {
            get
            {
                return logTienda._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entTienda> ListarRol()
        {
            return datTienda.Instancia.ListarTiendal();
        }

        //Inserta

        public bool InsertaTienda(entTienda t)
        {
            return datTienda.Instancia.InsertaTienda(t);
        }

        public bool EditaTienda(entTienda t)
        {
            return datTienda.Instancia.EditaTienda(t);
        }


        #endregion metodos
    }
}
