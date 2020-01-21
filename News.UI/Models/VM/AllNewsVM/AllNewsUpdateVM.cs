using News.Model.Entity.Concrete;
using News.UI.Models.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.UI.Models.VM.AllNewsVM
{
    public class AllNewsUpdateVM
    {
        public AllNewsUpdateVM()
        {
            AllNewsS = new AllNewsDTO();
            Categories = new List<Category>();
        }

        public List<Category> Categories { get; set; }
        public AllNewsDTO AllNewsS { get; set; }
    }
}