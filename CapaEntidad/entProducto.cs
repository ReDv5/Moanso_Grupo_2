using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int producto_id { get; set; }
        public String nombre { get; set; }
        public String descirpcion { get; set; }
        public double precio_unidad { get; set; }
        public String estado {  get; set; }
        public int categoria_id { get; set; }
    }
}

