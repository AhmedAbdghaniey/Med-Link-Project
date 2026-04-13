using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class PharmaRepresentative
    {

       
        public int PharmaRepresentativeId { get; set; }
        public string? CompanyPosition { get; set; }
        public RepresentativeStatus RepresentativeStatus { get; set; } //enum
        public int? PharmaCompanyId { get; set; } // FK
        public PharmaCompany PharmaCompany { get; set; } // Navigation Properity
        public int? UserId { get; set; } // FK
        public User C { get; set; } // Navigation Properity


    }
}
