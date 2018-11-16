using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bootcamp20.Micro.Common.Interfaces;
using Bootcamp20.Micro.DataAccess.Param;

namespace Bootcamp20.Micro.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService _supplierService;
        public SuppliersController() { }
        public SuppliersController(ISupplierService supplierService)
        {
            this._supplierService = supplierService;
        }
        // GET: Suppliers
        public ActionResult Index()
        {
            IEnumerable<SupplierParam> list_supplier = _supplierService.Get().Select(c => new SupplierParam
            {
                Id = c.Id,
                Name = c.Name.ToString() 
            });
            return View(list_supplier);
        }

        //Get Create
        public ActionResult Create()
        {
            return View();
        }

        //Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SupplierParam supplierParam)
        {
            if (ModelState.IsValid)
            {
                _supplierService.Insert(supplierParam);
                return RedirectToAction("Index");
            }

            return View(supplierParam);
        }

        //Get Edit
        public ActionResult Edit(int? id)
        {
            var supp = _supplierService.Get(id);
            var suppParam = new SupplierParam(supp);
            return View(suppParam);
        }

        //Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SupplierParam supplierParam)
        {
            if (ModelState.IsValid)
            {
                _supplierService.Update(supplierParam);
                return RedirectToAction("Index");
            }
            return View(supplierParam);
        }
        

        //GEt Delete
        //public ActionResult Delete(int? id)
        //{
        //    var supp = _supplierService.Get(id);
        //    var suppParam = new SupplierParam(supp);
        //    return View(suppParam);
        //}

        // POST: Suppliers
        [HttpPost]
        public ActionResult Delete(int id)
        {
            _supplierService.Delete(id);
            return RedirectToAction("Index");
        }


    }
}