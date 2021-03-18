using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BussinessLayer;

namespace EntityFramworkProject.Controllers
{
    public class CrudController : Controller
    {
        // GET: Crud
        private readonly IProductComponent _productComponent;
        public CrudController(IProductComponent productComponent)
        {
            _productComponent = productComponent;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Crud/Details/5
        public ActionResult Details(int id)
        {

            return View(_productComponent.GetSingleProduct(id));
        }
        public ActionResult DisplayProducts()
        {
            
            return View(_productComponent.GetProducts());
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Crud/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentEntities.Entities.Product model)
        {
            try
            {
                // TODO: Add insert logic here
                var added = _productComponent.AddProduct(model);
                return RedirectToAction(nameof(DisplayProducts), _productComponent.GetProducts());
            }
            catch(Exception e)
            {

                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            return View(_productComponent.GetSingleProduct(id));
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentEntities.Entities.Product model)
        {
            try
            {

                var edited = _productComponent.EditProdcut(id, model);
                return RedirectToAction(nameof(DisplayProducts),_productComponent.GetProducts());
            }
            catch
            {
                return View();
            }
        }

        // GET: Crud/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_productComponent.GetSingleProduct(id));
        }

        // POST: Crud/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentEntities.Entities.Product model)
        {
            try
            {
                // TODO: Add delete logic here
                _productComponent.DeleteProduct(id);
                return RedirectToAction(nameof(DisplayProducts), _productComponent.GetProducts());
            }
            catch
            {
                return View();
            }
        }
    }
}