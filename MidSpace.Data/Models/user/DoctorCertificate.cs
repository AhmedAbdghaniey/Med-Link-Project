using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models.user
{
    internal class DoctorCertificate
    {
        [Key]
        public int CertificateID { get; set; }
        public string CertificateName { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; }
        public int? DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}
