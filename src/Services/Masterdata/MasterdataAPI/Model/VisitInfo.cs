using System;
using System.Collections.Generic;

#nullable disable

namespace Masterdata.API.Model
{
    public partial class VisitInfo
    {
        public Guid VisitId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitTime { get; set; }
        public bool Completed { get; set; }

        public virtual DoctorInfo Doctor { get; set; }
        public virtual PatientInfo Patient { get; set; }
    }
}
