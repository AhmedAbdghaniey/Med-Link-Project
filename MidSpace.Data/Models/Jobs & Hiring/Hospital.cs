using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Hospital
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string? HospitalAddress { get; set; }
        public string? ContactPhoneNumber { get; set; }
        public string? ContactEmail { get; set; }
        public string? OfficialWebsiteUrl { get; set; }
        public string? HospitalDescription { get; set; }
        public ICollection<JobOpportunity> JobOpportunitys { get; set; } = new HashSet<JobOpportunity>();// Navigation Properity

    }
}
