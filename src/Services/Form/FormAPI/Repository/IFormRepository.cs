using Form.API.Model;
using System.Collections.Generic;

namespace Form.API.Repository
{
	public interface IFormRepository
	{
		IEnumerable<FormInfoViewModel> GetAllForms(FormMasterRequstModel model);
		public IEnumerable<FormInfoViewModel> AllActiveForms(FormMasterRequstModel model);
		public IEnumerable<VisitFormViewModel> AllFormsOfVisit(VisitRequestModel model);
	}
}