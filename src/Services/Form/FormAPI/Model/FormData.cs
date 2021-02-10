using System;
using System.Collections.Generic;

#nullable disable

namespace Form.API.Model
{
    public partial class FormData
    {
        public Guid DetailsId { get; set; }
        public Guid VisitId { get; set; }
        public Guid FormId { get; set; }
        public Guid DocumentId { get; set; }

        public virtual FormInfo Form { get; set; }
    }
}
