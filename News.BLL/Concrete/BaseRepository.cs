using News.BLL.Abstraction;
using News.DAL.Context;
using News.Model.Entity.Abstraction;
using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace News.BLL.Concrete
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private ProjectContext db;
        protected DbSet<T> table;
        public BaseRepository()
        {
                db = new ProjectContext();
                table = db.Set<T>();
        }
        public void Add(T item)
        {
            item.Status = Status.Active;
            table.Add(item);
            Save();
        }

        public void Delete(int id)
        {
            T item = GetByID(id);
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
            Save();
        }

        

        public List<T> GetActive()
        {
            return table.Where(x => x.Status != Status.Passive).ToList();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public void Update(T item)
        {
            T updated = GetByID(item.ID);
            DbEntityEntry entry = db.Entry(updated);
            entry.CurrentValues.SetValues(item);
            Save();
        }
    }
}
