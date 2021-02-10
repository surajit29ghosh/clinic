using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Model
{
	public class FormMasterRequstModel
	{
		public string DoctorId { get; set; }
	}

	public class SchemaRequestModel
	{
		public string FormId { get; set; }
	}

	public class VisitRequestModel
	{
		public string VisitId { get; set; }
	}
}
