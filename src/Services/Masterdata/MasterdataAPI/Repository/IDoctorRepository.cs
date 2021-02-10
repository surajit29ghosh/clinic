using Masterdata.API.Model;

namespace Masterdata.API.Repository
{
	public interface IDoctorRepository
	{
		DoctorViewModel GetDoctorDetails(DoctorRequestModel model);
	}
}