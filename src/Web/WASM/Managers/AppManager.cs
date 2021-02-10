using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Managers
{
	public class AppManager : IAppManager
	{
		public string MasterdataApiUrl { get; set; }
		public string FormApiUrl { get; set; }
	}
}
