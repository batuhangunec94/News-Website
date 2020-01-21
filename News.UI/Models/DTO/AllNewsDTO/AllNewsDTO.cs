using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.UI.Models.DTO.CategoryDTO
{
    public class AllNewsDTO : BaseDTO
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public int CategoryID { get; set; }
    }
}