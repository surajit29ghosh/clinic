using Form.API.Infrastructure;
using Form.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Repository
{
	public class FormRepository : IFormRepository
	{
		private readonly FormContext context;
		public FormRepository(FormContext dbContext)
		{
			context = dbContext;
		}

		public IEnumerable<FormInfoViewModel> GetAllForms(FormMasterRequstModel model)
		{
			return context.Forms.Where(d => d.DoctorId == Guid.Parse(model.DoctorId))
								.Include(s => s.Schemas)
								.Select(c => new FormInfoViewModel
								{
									FormId = c.FormId,
									FormName = c.FormName,
									EditInSummary = c.EditInSummary,
									ShowInSummary = c.ShowInSummary,
									PerVisit = c.PerVisit,
									IsActive = c.IsActive,
									NumberOfFields = c.Schemas.Count()
								}).ToList();
		}

		public IEnumerable<FormInfoViewModel> AllActiveForms(FormMasterRequstModel model)
		{
			return context.Forms.Where(d => d.DoctorId == Guid.Parse(model.DoctorId) && d.IsActive)
								.Include(s => s.Schemas)
								.Select(c => new FormInfoViewModel
								{
									FormId = c.FormId,
									FormName = c.FormName,
									EditInSummary = c.EditInSummary,
									ShowInSummary = c.ShowInSummary,
									PerVisit = c.PerVisit,
									IsActive = c.IsActive,
									NumberOfFields = c.Schemas.Count()
								}).ToList();
		}

		public IEnumerable<VisitFormViewModel> AllFormsOfVisit(VisitRequestModel model)
		{
			var query =  context.FormData.Where(f => f.VisitId == Guid.Parse(model.VisitId))
									.Include(s => s.Form);
			var result = query.ToList();

			return result.Select(v => new VisitFormViewModel
			{
				DetailsId = v.DetailsId,
				VisitId = v.VisitId,
				FormId = v.FormId,
				DocumentId = v.DocumentId,
				Form = new FormInfoViewModel
				{
					FormId = v.Form.FormId,
					FormName = v.Form.FormName,
					EditInSummary = v.Form.EditInSummary,
					IsActive = v.Form.IsActive,
					NumberOfFields = v.Form.Schemas.Count,
					ShowInSummary = v.Form.ShowInSummary,
					PerVisit = v.Form.PerVisit
				}
			}).ToList();
		}
	}
}
