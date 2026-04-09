using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Patient
    {
        [Key]
        public int PatientID { get; set; }
       

        public DateTime DOB { get; set; }
      
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string BloodType { get; set; } = string.Empty;
        public string EmergencyContact { get; set; } = string.Empty;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<PatientAllergy> Allergies { get; set; } = new HashSet<PatientAllergy>();
        public ICollection<PatientChronicDisease> Diseases { get; set; }=new HashSet<PatientChronicDisease>();

       
    }
}
