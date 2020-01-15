using News.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Map.Option
{
    public class AppUserMap:CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.AppUsers");

            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(15);
            Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(20);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(15);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(15);
            Property(x => x.Email).HasColumnName("Email").IsRequired().HasMaxLength(30);
            Property(x => x.Role).IsOptional();
        }
    }
}
