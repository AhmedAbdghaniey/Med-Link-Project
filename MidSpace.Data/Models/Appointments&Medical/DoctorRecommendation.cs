using MidSpace.Data.Models.user;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class DoctorRecommendation
    {
        [Key]
        public int RecommendationId { get; set; }

        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }

        public int RankOrder { get; set; }
        public string Reason { get; set; }
        public string RecommendationSource { get; set; }
        public DateTime GeneratedAt { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
