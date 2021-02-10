using System;
using System.Collections.Generic;

#nullable disable

namespace Masterdata.API.Model
{
    public partial class PatientInfo
    {
        public PatientInfo()
        {
            Visits = new HashSet<VisitInfo>();
        }

        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhone { get; set; }
        public int? PatientAge { get; set; }
        public string PatientGender { get; set; }

        public virtual ICollection<VisitInfo> Visits { get; set; }
    }
}
