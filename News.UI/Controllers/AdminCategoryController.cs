using News.Model.Entity.Concrete;
using News.UI.Models.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.UI.Controllers
{
    public class AdminCategoryController : BaseController
    {
        // GET: AdminCategory
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Category data)
        {
            service.CategoryService.Add(data);
            return Redirect("/List");
        }
        public ActionResult List()
        {
            List<Category> categories = service.CategoryService.GetActive();
            return View(categories);
        }
        public ActionResult Update(int id)
        {
            CategoryDTO model = new CategoryDTO();
            Category category = service.CategoryService.GetByID(id);
            model.ID = category.ID;
            model.Name = category.Name;
            return View(model);

        }
        [HttpPost]
        public ActionResult Update(CategoryDTO data)
        {
            Category category = service.CategoryService.GetByID(data.ID);
            category.Name = data.Name;
            category.UpdateDate = DateTime.Now;
            category.Status = Model.Entity.Abstraction.Status.Update;
            service.CategoryService.Update(category);
            return Redirect("/AdminCategory/List");
        }
        
        public ActionResult Delete(int id)
        {
            service.CategoryService.Delete(id);
            return Redirect("/AdminCategory/List");
        }
    }
}