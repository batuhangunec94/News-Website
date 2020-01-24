using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.UI.Models.VM.AllNewsVM
{
    public class AllNewsAddVM
    {
        public AllNewsAddVM()
        {
            Categories = new List<Category>();
        }
        public List<Category> Categories { get; set; }
    }
}