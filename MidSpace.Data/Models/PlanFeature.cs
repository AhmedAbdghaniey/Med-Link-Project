using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class PlanFeature
    {
        public int PlanFeatureId { get; set; } //PK
        public string PlanFeatureName { get; set; }
        public int? PlanId { get; set; } // foreign Key
        public Plan? Plan { get; set; } // Navigation Properity
    }
}
