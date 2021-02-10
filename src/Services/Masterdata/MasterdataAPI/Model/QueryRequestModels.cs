using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Model
{
	public class BaseModel
	{
		public string DoctorId { get; set; }
	}
	public class PagedModel
	{
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
	}

	public class PatientsRequestModel: BaseModel
	{
		public PagedModel Page { get; set; }
	}

	public class VisitDateRequestModel: BaseModel
	{
		public DateTime VisitDate { get; set; }
	}

	public class PatientDetailsRequestModel: BaseModel
	{
		public string PatientId { get; set; }
	}

	public class DoctorRequestModel
	{
		public string DoctorId { get; set; }
	}
}
