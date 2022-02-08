using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaStore.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new Contexto();
        }
         public List<Producto> ObtenerProductos()
        {
          

            return _contexto.Prooductos.ToList(); ;
        }

        
        
    }
}
