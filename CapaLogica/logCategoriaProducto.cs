using CapaAccesoADatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    internal class logCategoriaProducto
    {
        #region singleton
        // Patrón Singleton
        private static readonly logCategoriaProducto _instancia = new logCategoriaProducto();
        // Privado para evitar la instanciación directa
        public static logCategoriaProducto Instancia
        {
            get
            {
                return logCategoriaProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        /// Listado
        public List<entCategoriaProducto> ListarCategoriaProducto()
        {
            return datCategoriaProducto.Instancia.ListarCategoriaProducto();
        }

        // Inserta
        public bool InsertaCategoriaProducto(entCategoriaProducto c)
        {
            return datCategoriaProducto.Instancia.InsertaCategoriaProducto(c);
        }

        // Edita
        public bool EditaCategoriaProducto(entCategoriaProducto c)
        {
            return datCategoriaProducto.Instancia.EditaCategoriaProducto(c);
        }

        // Elimina
        public bool EliminaCategoriaProducto(int categoria_id)
        {
            return datCategoriaProducto.Instancia.EliminaCategoriaProducto(categoria_id);
        }
        #endregion metodos

    }
}
