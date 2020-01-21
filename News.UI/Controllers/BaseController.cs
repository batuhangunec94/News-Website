using News.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class BaseController : Controller
    {
        protected EntityService service;
        public BaseController()
        {
            service = new EntityService();
        }
    }
}