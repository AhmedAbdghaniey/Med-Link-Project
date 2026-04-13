using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class PharmaCompany
    {
        public int? PharmaCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhoneactEmai { get; set; }
        public string? ContactPhone { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? CompanyDescription { get; set; }
        public ICollection<PharmaRepresentative> PharmaRepresentatives { get; set; } = new HashSet<PharmaRepresentative>(); // Navigation Properity
        public ICollection<Drug> Drugs { get; set; } = new HashSet<Drug>(); // Navigation Properity
        public ICollection<Conference> Conferences { get; set; } = new HashSet<Conference>(); // Navigation Properity





    }

}
