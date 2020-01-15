using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model.Entity.Concrete
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        
        public List<AllNews> AllNews { get; set; }
    }
}
