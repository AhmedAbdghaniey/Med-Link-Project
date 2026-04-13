using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class ConferenceAttendance
    {
        public int ConferenceAttendanceId { get; set; }
        public int DoctorId { get; set; } // fk
        public Doctor Doctor { get; set; } // Navigation Properity
    }
}
