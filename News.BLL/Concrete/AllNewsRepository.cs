using News.DAL.Context;
using News.Model.Entity.Abstraction;
using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.BLL.Concrete
{
    public class AllNewsRepository : BaseRepository<AllNews>
    {
        ProjectContext db = new ProjectContext();
        public void GetLastNews()
        {
            db.Categories.Where(x => x.Status == Status.Active).Take(10);
        }
    }
}
