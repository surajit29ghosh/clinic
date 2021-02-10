using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
	public class DoctorModel
	{
		public Guid DoctorId { get; set; }
		public string DoctorName { get; set; }
		public string DoctorEmail { get; set; }
		public string DoctorPhone { get; set; }
	}
}
