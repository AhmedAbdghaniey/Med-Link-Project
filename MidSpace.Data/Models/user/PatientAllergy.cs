using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.user
{
    internal class PatientAllergy
    {
        [Key]
        public int AllergyID { get; set; }
        public string AllergyName { get; set; }
        public int? PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
