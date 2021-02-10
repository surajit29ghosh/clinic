using Form.API.Infrastructure;
using Form.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Repository
{
	public class SchemaRepository : ISchemaRepository
	{
		private FormContext context;

		public SchemaRepository(FormContext dbContext)
		{
			context = dbContext;
		}

		public FormSchemaViewModel GetSchemaOfForm(SchemaRequestModel model)
		{
			var query = context.Forms.Where(f => f.FormId == Guid.Parse(model.FormId))
									 .Include(s => s.Schemas);

			var result = query.FirstOrDefault();

			return new FormSchemaViewModel
			{
				Form = new FormInfoViewModel
				{
					FormId = result.FormId,
					FormName = result.FormName,
					IsActive = result.IsActive,
					EditInSummary = result.EditInSummary,
					ShowInSummary = result.ShowInSummary,
					NumberOfFields = result.Schemas.Count,
					PerVisit = result.PerVisit
				},
				Schemas = result.Schemas.Select(c => new SchemaInfoViewModel
				{
					FieldId = c.FieldId,
					FieldName = c.FieldName,
					FieldOrder = c.FieldOrder,
					FieldLabel = c.FieldLabel,
					FieldOptions = c.FieldOptions,
					FieldPlaceholder = c.FieldPlaceholder,
					FieldStyle = c.FieldStyle,
					FieldType = c.FieldType,
					FieldReadonly = c.FieldReadonly,
					FieldVisible = c.FieldVisible,
					FieldActive = c.FieldActive
				})
			};
		}
	}
}
