using System;
using System.Collections.Generic;

#nullable disable

namespace Masterdata.API.Model
{
    public partial class DoctorInfo
    {
        public DoctorInfo()
        {
            Visits = new HashSet<VisitInfo>();
        }

        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorPhone { get; set; }

        public virtual ICollection<VisitInfo> Visits { get; set; }
    }
}
