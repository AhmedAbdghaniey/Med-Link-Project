using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class Drug
    {
        [Key]
        public int DrugId { get; set; }
        public string DrugName { get; set; }

        public ICollection<PrescriptionItem> PrescriptionItems { get; set; }
    }
}
