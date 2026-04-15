using MidSpace.Data.Models.user;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }

        public DateTime Date { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<PrescriptionItem> Items { get; set; }
    }
}
