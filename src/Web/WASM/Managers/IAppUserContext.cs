namespace ClinicAnywhere.WASM.Managers
{
	public interface IAppUserContext
	{
		string DoctorId { get; set; }
		string PatientId { get; set; }
		bool UserIsDoctor { get; set; }
		bool UserIsPatient { get; set; }
		string UserRole { get; set; }
	}
}