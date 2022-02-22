﻿using FarmaStore.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaStore.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {

        ProductosBL _productosBL;
        private object _Categorias;

        public ProductosController()
        {
            _productosBL = new ProductosBL();
        }
        


        // GET: Productos
        public ActionResult Index()
        {

            var listadeproductos = _productosBL.ObtenerProductos();

            return View(listadeproductos);
        }

        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {

            if (ModelState.IsValid)
            {

                if (producto.categoriaId == 0)
                {
                    ModelState.AddModelError("CategoriaId", "seleccione una categoria");
                    return View(producto);
                }
                _productosBL.GuardarProducto(producto);

                return RedirectToAction("Index");
            }


            return View(producto);
        }

        public ActionResult Editar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            return View();

        }

        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");

        }
        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            return View(producto);
        }
        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.Id);
            return RedirectToAction("Index");
        }

    }
}