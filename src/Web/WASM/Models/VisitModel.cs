using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Models
{
    public class VisitModel
    {
        public Guid VisitId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitTime { get; set; }
        public bool Completed { get; set; }
    }
}
