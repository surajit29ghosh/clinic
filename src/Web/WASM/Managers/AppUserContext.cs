using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Managers
{
	public class AppUserContext : IAppUserContext
	{
		public string DoctorId { get; set; }
		public string PatientId { get; set; }
		public bool UserIsDoctor { get; set; }
		public bool UserIsPatient { get; set; }
		public string UserRole { get; set; }
	}
}
