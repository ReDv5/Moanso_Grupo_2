using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleado
    {
        public int empleado_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public string contacto { get; set; }
        public string estado { get; set; }
        public int rol_id { get; set; }

        public int tienda_id { get; set; }


    }
}
