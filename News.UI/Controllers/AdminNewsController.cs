using News.Model.Entity.Abstraction;
using News.Model.Entity.Concrete;
using News.UI.Models.DTO.CategoryDTO;
using News.UI.Models.VM.AllNewsVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class AdminNewsController : BaseController
    {
        [HttpGet]
        public ActionResult Add()
        {
            AllNewsAddVM model = new AllNewsAddVM()
            {
                Categories = service.CategoryService.GetActive()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(AllNewsDTO data)
        {
            AllNews model = new AllNews();
            model.Header = data.Header;
            model.Description = data.Description;
            model.Content = data.Content;
            model.Image = data.Image;
            model.Status = Status.Active;
            model.AddDate = DateTime.Now;
            model.CategoryID = data.CategoryID;
            service.AllNewsService.Add(model);
            return Redirect("/AdminNews/List");

        }
        public ActionResult List()
        {
            List<AllNews> model = service.AllNewsService.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            AllNewsUpdateVM news = new AllNewsUpdateVM();
            AllNews model = service.AllNewsService.GetByID(id);
            news.AllNewsS.ID = model.ID;
            news.AllNewsS.Header = model.Header ;
            news.AllNewsS.Content = model.Content ;
            news.AllNewsS.Image = model.Image;
            news.Categories = service.CategoryService.GetActive();
            return View(news);
        }
        [HttpPost]
        public ActionResult Update(AllNewsDTO data)
        {
            AllNews model = service.AllNewsService.GetByID(data.ID);
            model.Header = data.Header;
            model.Description = data.Description;
            model.Content = data.Content;
            model.Image = data.Image;
            model.CategoryID = data.CategoryID;
            model.Status = Status.Update;
            model.UpdateDate = DateTime.Now;
            service.AllNewsService.Update(model);
            return Redirect("/AdminNews/List");

        }
        public ActionResult Delete(int id)
        {
            service.AllNewsService.Delete(id);
            return Redirect("/AdminNews/List");
        }
    }
}