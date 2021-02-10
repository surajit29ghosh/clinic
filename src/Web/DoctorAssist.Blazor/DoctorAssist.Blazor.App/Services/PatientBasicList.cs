using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAssist.Blazor.App.Services
{
    public class PatientBasicList
    {
        public Guid PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }
        public string PatientPhone { get; set; }

        public DateTime VisitDate { get; set; }
        public string FormattedDate
        { get
            {
                return VisitDate.ToString("dd/MM/yyyy");
            }
        }

        public string VisitTime { get; set; }
    }
}
