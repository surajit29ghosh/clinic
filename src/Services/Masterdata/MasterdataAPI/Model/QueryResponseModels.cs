using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Model
{
	public class PatientViewModel
	{
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientPhone { get; set; }
		public int TotalVisits { get; set; }
		public DateTime LastVisitDate { get; set; }

	}

	public class PatientDetailsViewModel
	{
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhone { get; set; }
        public int? PatientAge { get; set; }
        public string PatientGender { get; set; }

        public virtual ICollection<VisitViewModel> Visits { get; set; }
    }

    public class VisitViewModel
    {
        public Guid VisitId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitTime { get; set; }
        public bool Completed { get; set; }
    }

    public class DoctorViewModel
	{
        public Guid DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorPhone { get; set; }
    }
}
