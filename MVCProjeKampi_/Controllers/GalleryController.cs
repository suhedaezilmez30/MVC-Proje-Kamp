using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamam.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFaileManager ifm = new ImageFaileManager(new EfImageDal());

        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
    }
}