using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.Appointments_Medical
{
    internal class MedicalAttachment
    {
        public int AttachmentId { get; set; }

        public int RecordId { get; set; }

        public string FileURL { get; set; }
        public string FileType { get; set; }
        public DateTime UploadedAt { get; set; }

        public MedicalRecord MedicalRecord { get; set; }
    }
}
