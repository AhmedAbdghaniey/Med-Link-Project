using MidSpace.Data.Models.user;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
     
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }

        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public decimal ConsultationFeeAtBooking { get; set; }
        public string CancellationReason { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

         Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}
