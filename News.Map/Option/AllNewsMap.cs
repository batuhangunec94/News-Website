using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Map.Option
{
    public class AllNewsMap:CoreMap<AllNews>
    {
        public AllNewsMap()
        {
            ToTable("dbo.AllNews");
            Property(x => x.Header).HasMaxLength(30).IsRequired().HasColumnName("Header");
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasMaxLength(50);
            Property(x => x.Content).HasColumnName("Content").IsRequired().HasMaxLength(300);
            Property(x => x.Image).HasColumnName("Image").IsOptional();

            HasRequired(x => x.Category).WithMany(x => x.AllNews);
        }
    }
}
