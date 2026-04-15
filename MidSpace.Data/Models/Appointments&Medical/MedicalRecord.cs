using MidSpace.Data.Models.user;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class MedicalRecord
    {
        [Key]
        public int RecordId { get; set; }

        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int AppointmentId { get; set; }

        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public string VisitType { get; set; }

        public DateTime FollowUpDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Appointment Appointment { get; set; }

        public ICollection<MedicalAttachment> Attachments { get; set; }
    }
}
