using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.UI.Models.DTO.CategoryDTO
{
    public class CategoryDTO :BaseDTO
    {
        public string Name { get; set; }
        public DateTime Update { get; set; }
    }
}