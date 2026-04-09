using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Subscription
    {
        public int SubscriptionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AutoRenew { get; set; }
        public string Status { get; set; } = string.Empty;
        public int? UserId { get; set; } // Foreign Key
        public int? PlanId { get; set; } // foreign Keu
        public User? User { get; set; }  // Navigation Properity
        public Plan? Plan { get; set; } //Navigation Properity
        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>(); // navigation properity

    }
}
