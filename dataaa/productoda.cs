using EF;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dataaa
{
    public class productosda
    {
        private readonly db_taeraEntities context;

        public productosda()
        {
            context = new db_taeraEntities();
        }

        public List<Producto> ListarActivas()
        {


            var query = (from can in context.productos
                         where can.activo.Equals(true)
                         select new Producto
                         {
                             id_producto = can.id_producto,
                             nombre_producto = can.nombre_producto
                         }).ToList();


            return query;
        }
    }
}
   