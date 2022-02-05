using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaStore.BL
{
    public class ProductosBL
    {
         public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Neurobion Dc 2500 con 1 jeringa";
            producto1.Precio = 310;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Oxivasc 10 Mg x 30 tabletas";
            producto2.Precio = 292;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pregavan 75 Mg x 30 Capsulas";
            producto3.Precio =741;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);



            return listadeProductos;
        }

        
        
    }
}
