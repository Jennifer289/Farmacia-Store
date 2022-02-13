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
            _productosBL.GuardarProducto(producto);

            return RedirectToAction("Index");
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
    }
}