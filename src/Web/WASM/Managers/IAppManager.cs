namespace ClinicAnywhere.WASM.Managers
{
	public interface IAppManager
	{
		string MasterdataApiUrl { get; set; }
		string FormApiUrl { get; set; }
	}
}