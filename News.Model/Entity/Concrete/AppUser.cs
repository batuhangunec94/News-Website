using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Model.Entity.Concrete
{
    public enum Role
    {
        None = 0,
        Admin = 1,
        Moderator = 2,
        Author= 3
    }
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }


    }
}
