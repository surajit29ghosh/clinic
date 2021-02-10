using Masterdata.API.Model;
using System;
using System.Collections.Generic;

namespace Masterdata.API.Repository
{
	public interface IPatientRepository
	{
		IEnumerable<PatientViewModel> GetAll(string doctorId);
		IEnumerable<PatientViewModel> GetPaged(string doctorId, int pageSize, int pageNumber);
		public IEnumerable<PatientViewModel> GetPatientByVisitDate(string doctorId, DateTime visitDate);
		public PatientDetailsViewModel GetPatientDetails(PatientDetailsRequestModel model);
	}
}