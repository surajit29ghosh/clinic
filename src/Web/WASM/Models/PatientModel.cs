using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
	public class PatientModel
	{
		public Guid PatientId { get; set; }
		public string PatientName { get; set; }
		public string PatientPhone { get; set; }
		public DateTime LastVisitDate { get; set; }

	}
}
