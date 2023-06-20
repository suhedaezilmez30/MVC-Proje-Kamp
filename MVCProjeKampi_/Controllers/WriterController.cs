using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFramwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamam.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriter());
        WriterValidator writevalidator = new WriterValidator();
        public ActionResult Index()
        {
            var writervalues = wm.GetList();
            return View(writervalues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
          
            ValidationResult results = writevalidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriteAdd(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           return View();
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writervalue=wm.GetByID(id);
          
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            ValidationResult results = writevalidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriteUpdate(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}