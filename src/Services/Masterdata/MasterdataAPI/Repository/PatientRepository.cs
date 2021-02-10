using Masterdata.API.Infrastructure;
using Masterdata.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masterdata.API.Repository
{
	public class PatientRepository : IPatientRepository
	{
		private readonly MasterdataContext context;
		public PatientRepository(MasterdataContext dbContext)
		{
			this.context = dbContext;
		}

		public IEnumerable<PatientViewModel> GetAll(string doctorId)
		{
			var query = context.Visits.Where(doc => doc.DoctorId.Equals(doctorId))
					.Include(v => v.Patient);

			return query.Select(c => new PatientViewModel
			{
				PatientId = c.PatientId,
				PatientName = c.Patient.PatientName,
				PatientPhone = c.Patient.PatientPhone,
				TotalVisits = c.Patient.Visits.Count,
				LastVisitDate = query.Where(visit => visit.PatientId.Equals(c.Patient)).OrderByDescending(o => o.VisitDate).FirstOrDefault().VisitDate
			}).ToList();
		}

		public IEnumerable<PatientViewModel> GetPaged(string doctorId, int pageSize, int pageNumber)
		{
			var query = context.Visits.Where(doc => doc.DoctorId == Guid.Parse(doctorId))
					.Include(v => v.Patient);

			if(pageNumber > 1)
			{
				query.Skip(pageSize * pageNumber);
			}

			query.Take(pageSize);

			return query.Select(c => new PatientViewModel
			{
				PatientId = c.PatientId,
				PatientName = c.Patient.PatientName,
				PatientPhone = c.Patient.PatientPhone,
				TotalVisits = c.Patient.Visits.Count,
				LastVisitDate = query.Where(visit => visit.PatientId.Equals(c.PatientId)).OrderByDescending(o => o.VisitDate).FirstOrDefault().VisitDate
			}).ToList();
		}

		public IEnumerable<PatientViewModel> GetPatientByVisitDate(string doctorId, DateTime visitDate)
		{
			var query = context.Visits.Where(doc => doc.DoctorId == Guid.Parse(doctorId))
					.Include(v => v.Patient);

			query.Where(c => c.VisitDate == visitDate);

			return query.Select(c => new PatientViewModel
			{
				PatientId = c.PatientId,
				PatientName = c.Patient.PatientName,
				PatientPhone = c.Patient.PatientPhone,
				TotalVisits = c.Patient.Visits.Count,
				LastVisitDate = query.Where(visit => visit.PatientId.Equals(c.PatientId)).OrderByDescending(o => o.VisitDate).FirstOrDefault().VisitDate
			}).ToList();
		}

		public PatientDetailsViewModel GetPatientDetails(PatientDetailsRequestModel model)
		{
			var query = context.Patients.Where(p => p.PatientId == Guid.Parse(model.PatientId))
										.Include(v => v.Visits)
										.Where(v => v.Visits.Any(x => x.DoctorId == Guid.Parse(model.DoctorId)));

			return query.Select(p => new PatientDetailsViewModel
			{
				PatientId = p.PatientId,
				PatientAge = p.PatientAge,
				PatientEmail = p.PatientEmail,
				PatientGender = p.PatientGender,
				PatientName = p.PatientName,
				PatientPhone = p.PatientPhone,
				Visits = p.Visits.Select(c => new VisitViewModel
				{
					DoctorId = c.DoctorId,
					PatientId = c.PatientId,
					Completed = c.Completed,
					VisitId = c.VisitId,
					VisitDate = c.VisitDate,
					VisitTime = c.VisitTime

				}).ToList()
			}).FirstOrDefault();
				
		}
	}
}
