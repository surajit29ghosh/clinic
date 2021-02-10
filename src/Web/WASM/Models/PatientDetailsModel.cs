using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
    public class PatientDetailsModel
    {
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhone { get; set; }
        public int? PatientAge { get; set; }
        public string PatientGender { get; set; }

        public virtual ICollection<VisitModel> Visits { get; set; }
    }

    
}
