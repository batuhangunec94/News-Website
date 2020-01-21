using News.Model.Entity.Abstraction;
using News.Model.Entity.Concrete;
using News.UI.Models.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class AdminNewsController : BaseController
    {
        // GET: AdminNews
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Add(AllNewsDTO data)
        {
            AllNews model = new AllNews();
            model.Header = data.Header;
            model.Description = data.Description;
            model.Content = data.Content;
            model.Image = data.Image;
            model.Status = Status.Active;
            model.AddDate = DateTime.Now;
            return Redirect("AdminAllNews/List");

        }
        public ActionResult List()
        {
            List<AllNews> model = service.AllNewsService.GetAll();
            return View(model);
        }
    }
}