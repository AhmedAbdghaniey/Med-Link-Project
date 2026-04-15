using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.user
{
    internal class Admin
    {
        [Key, ForeignKey("User")]
        public int AdminId { get; set; } 

        public string Role { get; set; } 

        public virtual User User { get; set; }
    }
}
