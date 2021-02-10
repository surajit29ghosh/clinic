using System;
using System.Collections.Generic;

#nullable disable

namespace Form.API.Model
{
    public partial class FormInfo
    {
        public FormInfo()
        {
            FormData = new HashSet<FormData>();
            Schemas = new HashSet<SchemaInfo>();
        }

        public Guid FormId { get; set; }
        public string FormName { get; set; }
        public Guid DoctorId { get; set; }
        public bool IsActive { get; set; }
        public bool ShowInSummary { get; set; }
        public bool EditInSummary { get; set; }
        public bool PerVisit { get; set; }

        public virtual ICollection<FormData> FormData { get; set; }
        public virtual ICollection<SchemaInfo> Schemas { get; set; }
    }
}
