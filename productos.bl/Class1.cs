using dataaa;
using EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static productos.bl.Class1;


namespace productos.bl
{
    public class Class1
    {
        public class Productobl
        {
            private readonly productosda objproductoda;
            public Productobl()
            {
                objproductoda = new productosda();
            }

            public List<db_tareaEntities> ListarActivas()
            {
                try
                {
                    return objproductoda.ListarActivas();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
