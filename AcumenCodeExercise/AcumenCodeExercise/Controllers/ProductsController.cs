using AcumenCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcumenCodeExercise.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsProvider _productsProvider;

        public ProductsController()
        {
            _productsProvider = new DapperProductsProvider(ConfigurationManager.ConnectionStrings["Sql"].ConnectionString);
        }
        
        
        // GET: Products
        public ActionResult Index()
        {
            var model = _productsProvider.GetProducts();
            return View(model);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Product p)
        {
            try
            {
                // TODO: Add insert logic here
                _productsProvider.Add(p);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
