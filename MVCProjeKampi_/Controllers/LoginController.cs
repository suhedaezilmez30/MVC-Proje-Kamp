using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using MVCUygulamam.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCProjeKampi_.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c=new Context();
            var adminUserinfo=c.admins.FirstOrDefault(x=>x.AdminUserName==p.AdminUserName&&x.AdminPassword==p.AdminPassword);
            if (adminUserinfo!=null)
            {
                FormsAuthentication.SetAuthCookie(adminUserinfo.AdminUserName,false);
                Session["AdminUserName"]=adminUserinfo.AdminUserName;
                return RedirectToAction("Index","AdminCategor");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}