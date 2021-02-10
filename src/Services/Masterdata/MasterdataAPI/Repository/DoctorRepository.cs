using Masterdata.API.Infrastructure;
using Masterdata.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Repository
{
	public class DoctorRepository : IDoctorRepository
	{
		private MasterdataContext context;

		public DoctorRepository(MasterdataContext db)
		{
			context = db;
		}

		public DoctorViewModel GetDoctorDetails(DoctorRequestModel model)
		{
			var query = context.Doctors.Where(d => d.DoctorId == Guid.Parse(model.DoctorId));

			return query.Select(s => new DoctorViewModel
			{
				DoctorId = s.DoctorId,
				DoctorName = s.DoctorName,
				DoctorEmail = s.DoctorEmail,
				DoctorPhone = s.DoctorPhone
			}).FirstOrDefault();
		}
	}
}
