using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pedido
    {
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int id_usuario { get; set; }
        public int cantidad_productos { get; set; }
        public DateTime fecha { get; set; }
        public int hora { get; set; }
        public bool estado { get; set; }
    }
}
