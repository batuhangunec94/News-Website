using News.BLL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EntityService
    {
        public EntityService()
        {
            _allNewsRepository = new AllNewsRepository();
            _categoryService = new CategoryRepository();
            _appUserService = new AppUserRepository();
            
        }
        private CategoryRepository _categoryService;
        public CategoryRepository CategoryService { get { return _categoryService; } set { _categoryService = value; } }

        private AppUserRepository _appUserService;
        public AppUserRepository AppUserService { get { return _appUserService; } set { _appUserService = value; } }

        private AllNewsRepository _allNewsRepository;
        public AllNewsRepository AllNewsService { get { return _allNewsRepository; } set { _allNewsRepository = value; } }
    }
}
