﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamam.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult Page403()
        {
            Response.StatusCode = 403;   //response yönlendirme
             Response.TrySkipIisCustomErrors = true;
            return View();
        } 
        public ActionResult Page404()
        {
            Response.StatusCode = 404;   //response yönlendirme
             Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}