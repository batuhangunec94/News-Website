using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model.Entity.Concrete
{
    public class AllNews:BaseEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
