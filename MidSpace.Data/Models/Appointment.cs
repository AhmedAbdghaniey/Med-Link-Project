using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Appointment
    {
        public int AppointmentId { get; set; }
        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>(); // navigation properity
    }
}
