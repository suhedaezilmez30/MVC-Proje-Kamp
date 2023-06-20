using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFramwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamam.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm=new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidatior  categoryValidatior = new CategoryValidatior();
            ValidationResult result = categoryValidatior.Validate(p);
            if (result.IsValid) //sonuç geçerliyse
            {
                cm.CategoryAddBl(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
    }
}