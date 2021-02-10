using System;
using System.Collections.Generic;

#nullable disable

namespace Form.API.Model
{
    public partial class SchemaInfo
    {
        public Guid FormId { get; set; }
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

        public virtual FormInfo Form { get; set; }
    }
}
