﻿using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class HomeController : BaseController
    {
        
        // GET: Home
        public ActionResult Index()
        {
             
            return View(service.AllNewsService.GetActive().ToList());
        }
    }
}