using Masterdata.API.Infrastructure;
using Masterdata.API.Model;
using Masterdata.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PatientController : ControllerBase
	{
		private readonly IPatientRepository patientRepo;
		public PatientController(IPatientRepository patient)
		{
			patientRepo = patient;
		}

		[HttpPost]
		[Route("all")]
		public IEnumerable<PatientViewModel> GetPage(PatientsRequestModel patients)
		{
			return patientRepo.GetPaged(patients.DoctorId, patients.Page.PageSize, patients.Page.PageNumber);
		}

		[HttpPost]
		[Route("visitdate")]
		public IEnumerable<PatientViewModel> GetVisitByDate(VisitDateRequestModel patients)
		{
			return patientRepo.GetPatientByVisitDate(patients.DoctorId, patients.VisitDate);
		}

		[HttpPost]
		[Route("details")]
		public PatientDetailsViewModel Details(PatientDetailsRequestModel model )
		{
			return patientRepo.GetPatientDetails(model);
		}
	}
}
