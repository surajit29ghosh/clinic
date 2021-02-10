using Form.API.Model;
using Form.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FormController : ControllerBase
	{
		private IFormRepository formRepo;
		public FormController(IFormRepository form)
		{
			formRepo = form;
		}

		[HttpPost]
		[Route("all")]
		public IEnumerable<FormInfoViewModel> AllFormsofDoctor(FormMasterRequstModel model)
		{
			return formRepo.GetAllForms(model);
		}

		[HttpPost]
		[Route("active")]
		public IEnumerable<FormInfoViewModel> ActiveFormsofDoctor(FormMasterRequstModel model)
		{
			return formRepo.AllActiveForms(model);
		}

		[HttpPost]
		[Route("visit")]
		public IEnumerable<VisitFormViewModel> FormsOfVisit(VisitRequestModel model)
		{
			return formRepo.AllFormsOfVisit(model);
		}
	}
}
