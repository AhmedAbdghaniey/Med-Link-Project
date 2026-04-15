using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class PrescriptionItem
    {
        [Key]
        public int ItemId { get; set; }

        public int PrescriptionId { get; set; }
        public int DrugId { get; set; }

        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string Duration { get; set; }
        public string Instructions { get; set; }

        public Prescription Prescription { get; set; }
        public Drug Drug { get; set; }
    }
}
