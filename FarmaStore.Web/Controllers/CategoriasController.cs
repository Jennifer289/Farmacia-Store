using FarmaStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaStore.Web.Controllers
{
    public class CategoriasController : Controller
    {
        private object listadeCategorias;

        // GET: Categorias
        public ActionResult Index()
        {

            var categoriasBL = new CategoriasBL();
            var listaProductos = categoriasBL.ObtenerCategoria();

            return View(listadeCategorias);
            
        }
    }
}