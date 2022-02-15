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
        public List<Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }
         public List<Producto> ObtenerProductos()
        {

            ListadeProductos = _contexto.Prooductos.ToList();
            return ListadeProductos;
        }

        public void GuardarProducto(Producto producto)
        {
            if(producto.Id == 0 )
            {
                _contexto.Prooductos.Add(producto);

            }else
            {
                var productoExistente = _contexto.Prooductos.Find(producto.Id);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
            }


            _contexto.SaveChanges();
        }

        public object ObtenerCategoria(int id)
        {
            throw new NotImplementedException();
        }

        public void GuardarCategoria(Categoria producto)
        {
            throw new NotImplementedException();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Prooductos.Find(id);

            return producto;
        }

        public void EliminarProducto(int id)
        {
            var producto = _contexto.Prooductos.Find(id);

            _contexto.Prooductos.Remove(producto);
            _contexto.SaveChanges();
        }

        public void EliminarCategoria(int id)
        {
            throw new NotImplementedException();
        }
    }
}
