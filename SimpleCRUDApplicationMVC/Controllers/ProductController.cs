using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCRUDApplicationMVC.Models;
using System.Data.Entity;

namespace SimpleCRUDApplicationMVC.Controllers
{
    public class ProductController : Controller
    {
        ProductContext db = new ProductContext();


        // GET: /Product/
        public ActionResult GetProducts()
        {
            var prodList = db.products.ToList();
            return View(prodList);
        }
        public ActionResult GetProduct(int? Id)
        {
            var product = db.products.Where(p => p.Id == Id).FirstOrDefault();
            return View(product);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Products productModel)
        {
            if (ModelState.IsValid)
            {
                db.products.Add(productModel);
                db.SaveChanges();
                return RedirectToAction("GetProducts");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Update(int Id)
        {
            var prod = db.products.Find(Id);
            return View(prod);
        }

        [HttpPost]
        public ActionResult Update(Products product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("GetProducts");
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var product = db.products.Find(Id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(int? Id)
        {
            if (ModelState.IsValid)
            {
                var prod = db.products.Find(Id);
                db.products.Remove(prod);
                db.SaveChanges();
                return RedirectToAction("GetProducts");
            }
            else
            {
                return View();
            }

        }
    }
}