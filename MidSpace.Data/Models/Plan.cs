using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Plan
    {
        public int PlanId { get; set; } // PK
        public string PlanName { get; set; } = string.Empty;
        public string PlanDescription { get; set; } = string.Empty;
        public decimal PlanPrice { get; set; } // decimal(10,2)
        public string BillingCycle {  get; set; } = string.Empty;
        public ICollection<Subscription> Subscriptions { get; set; } = new HashSet<Subscription>();
        public ICollection<PlanFeature> PlanFeatures { get; set; } = new HashSet<PlanFeature>();



    }
}
