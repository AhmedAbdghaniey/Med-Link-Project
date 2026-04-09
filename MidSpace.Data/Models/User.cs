using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class User
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        [Required, MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string? ProfileImage { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Subscription> Subscriptions { get; set; } = new HashSet<Subscription>(); // Navigation Properity
        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>(); // Navigation Properity
        public ICollection<UserPhone> Phones { get; set; } = new HashSet<UserPhone>();
        public virtual Doctor? Doctor { get; set; } 
        public virtual Patient? Patient { get; set; }
        public virtual Admin? Admin { get; set; }


    }
}
