using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Conference
    {
        public int ConferenceId { get; set; }
        public string Title { get; set; }
        public string? Location { get; set; }
        public DateTime? ConferenceDate { get; set; }
        public DateTime? RegistrationDeadline { get; set; }
        public int? Capacity { get; set; }
        public string? Description { get; set; }
        public int? PharmaCompanyId { get; set; } // FK
        public PharmaCompany PharmaCompany  { get; set; } // Navigation Properity
        public ICollection<Doctor> Doctors { get; set; } = new HashSet<Doctor>();// Navigation Properity

    }
}
