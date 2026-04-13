using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Drug
    {
        
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DrugApprovalStatus ApprovalStatus { get; set; } // enum
        public int? pharmaCompanyId { get; set; } // FK
        public PharmaCompany pharmaCompany { get; set; } // Navigation Properity



    }
}
