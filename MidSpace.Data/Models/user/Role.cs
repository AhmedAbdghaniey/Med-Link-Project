using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.user
{
    internal class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
