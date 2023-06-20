using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamam.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriter());
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {//kategori listesine gitmek içi
            List<SelectListItem> valuecategory = (from x in hm.GetList()
                                                      //categori listesine ulaşmak için yaptık
                                                  select new SelectListItem
                                                  {
                                                      Text = x.HeadingName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            //     ViewBag aldığımız listeyi taşımak için
            List<SelectListItem> valuewriter = (from x in hm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Writer.WriterName + " " + x.Writer.WriterSurName,
                                                    Value = x.WriterID.ToString()
                                                }
                                            ).ToList();


            ViewBag.vlc = valuecategory;
            ViewBag.vlv = valuewriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditHeading(int id)
        {


            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                      //categori listesine ulaşmak için yaptık
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CtegoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;


            var headingvalues = hm.GetByID(id);
            return View(headingvalues);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteHeading(int id)
        {
            var headingvalue = hm.GetByID(id);
            hm.HeadingDelete(headingvalue);
            return RedirectToAction("Index");
        }
    }
}