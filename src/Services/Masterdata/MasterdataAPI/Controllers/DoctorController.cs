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
	public class DoctorController : ControllerBase
	{
		private IDoctorRepository doctorRepo;

		public DoctorController(IDoctorRepository doc)
		{
			doctorRepo = doc;
		}

		[HttpPost]
		[Route("details")]
		public DoctorViewModel GetDoctorDetails(DoctorRequestModel model)
		{
			return doctorRepo.GetDoctorDetails(model);
		}
	}
}
