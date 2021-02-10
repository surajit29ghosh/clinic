 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Form.API.Model
{
	public class FormInfoViewModel
	{
        public Guid FormId { get; set; }
        public string FormName { get; set; }
        public bool IsActive { get; set; }
        public bool ShowInSummary { get; set; }
        public bool EditInSummary { get; set; }
        public bool PerVisit { get; set; }
		public int NumberOfFields { get; set; }
    }

    public class SchemaInfoViewModel
	{
        public int FieldId { get; set; }
        public int FieldOrder { get; set; }
        public string FieldType { get; set; }
        public string FieldName { get; set; }
        public string FieldLabel { get; set; }
        public string FieldPlaceholder { get; set; }
        public string FieldOptions { get; set; }
        public string FieldStyle { get; set; }
        public bool? FieldActive { get; set; }
        public bool FieldReadonly { get; set; }
        public bool? FieldVisible { get; set; }
    }

    public class FormSchemaViewModel
	{
		public FormInfoViewModel Form { get; set; }

        public IEnumerable<SchemaInfoViewModel> Schemas { get; set; }
	}

    public class VisitFormViewModel
    {
        public Guid DetailsId { get; set; }
        public Guid VisitId { get; set; }
        public Guid FormId { get; set; }
        public Guid DocumentId { get; set; }

        public virtual FormInfoViewModel Form { get; set; }
    }
}
