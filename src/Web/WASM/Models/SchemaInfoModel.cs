using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
    public class SchemaInfoModel
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
}
