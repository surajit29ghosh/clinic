using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
    public class FormInfoModel
    {
        public Guid FormId { get; set; }
        public string FormName { get; set; }
        public bool IsActive { get; set; }
        public bool ShowInSummary { get; set; }
        public bool EditInSummary { get; set; }
        public bool PerVisit { get; set; }
        public int NumberOfFields { get; set; }
    }
}
