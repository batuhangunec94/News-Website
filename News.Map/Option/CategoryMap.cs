using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Map.Option
{
    public class CategoryMap:CoreMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).HasColumnName("Name").HasMaxLength(25).IsRequired();
            HasMany(x => x.AllNews).WithRequired(x => x.Category).HasForeignKey(x => x.CategoryID).WillCascadeOnDelete(false);

        }
    }
}
