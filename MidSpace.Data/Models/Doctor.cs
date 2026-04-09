using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Doctor
    {
        [Key]
        public int DoctorId { get; set; } 
        public string Specialization { get; set; } = string.Empty;
        public string LicenseNumber { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }
        public string? Bio { get; set; }
        public string? AvailabilityStatus { get; set; }

        public double DoctorScore { get; set; }
       
        public decimal ConsultationFee { get; set; }
       
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<DoctorCertificate> Certificates { get; set; }= new HashSet<DoctorCertificate>();
        public ICollection<DoctorAvailability> Availabilities { get; set; }= new HashSet<DoctorAvailability>();
    }
}
