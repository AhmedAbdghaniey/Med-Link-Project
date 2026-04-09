using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class UserPhone
    {
        [Key]
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
