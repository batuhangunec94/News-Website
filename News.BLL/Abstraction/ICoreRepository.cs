using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace News.BLL.Abstraction
{
    public interface ICoreRepository<T>
    {

        List<T> GetAll();
        List<T> GetActive();
        T GetByID(int id);
        void Add(T item);
        void Add(List<T> item);
        void Update(T item);
        void Delete(int id);
        
        int Save();
    }
}
