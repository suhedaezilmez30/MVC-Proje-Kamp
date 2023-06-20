using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;


namespace MVCUygulamam.Controllers
{
    public class IstatistikController : Controller
    {
        Context cont=new Context();
        

        // GET: Istatistik
        public ActionResult Index()
        {
            //Toplam kategori sayısı
            int CategoryAdet = cont.Categories.Count();
            ViewBag.CategoryAdet = CategoryAdet;

            // Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            int Yazilim = cont.Headings.Count(x => x.HeadingName == "yazılım");
            ViewBag.YazilimHeading = Yazilim;

            //  Yazar adında 'a' harfi geçen yazar sayısı
            int AicerenYazar = cont.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.AicerenYazar = AicerenYazar;

            // En fazla başlığa sahip kategori adı
            var catbas = cont.Headings.Max(x => x.Category.CtegoryName);
            ViewBag.catbas = catbas;


            //  Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark

            int TrueStatue = cont.Categories.Count(x => x.CategoryStatus == true);
            int FalseStatue = cont.Categories.Count(x => x.CategoryStatus == false);
            int fark = TrueStatue - FalseStatue;
             ViewBag.Fark = fark;


            return View();
        }
    }
}