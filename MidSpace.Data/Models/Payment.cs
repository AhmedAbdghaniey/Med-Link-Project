using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Payment
    {
        public int PaymentId { get; set; } //PK
        public decimal Amount { get; set; }
        public string Currency {  get; set; }
        public string PaymentMethod { get; set; }
        public string? TransactionId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        public int UserId { get; set; } // foreign Key
        public int? SubscriptionId { get; set; } // foreign key
        public int? AppointmentId { get; set; } // foreign key
        public User User { get; set; } //Navigation Properity
        public Subscription? Subscription { get; set; } // Navigation Properity
        public Appointment? Appointment { get; set; } // navigation properity


    }
}
