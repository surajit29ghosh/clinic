using ClinicAnywhere.WASM.Managers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http;

namespace ClinicAnywhere.WASM.Shared
{
	public class CAComponentBase: ComponentBase
	{
		[Inject]
		protected HttpClient client { get; set; }
		[Inject]
		private NavigationManager NavigationMgr { get; set; }
		[Inject]
		protected IAppManager appManager { get; set; }
		[Inject]
		private IJSRuntime JsRuntime { get; set; }
		[Inject]
		public IAppUserContext userContext { get; set; }

		protected async void TryFragmentNavigation(object sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
		{
			await NavigationMgr.NavigateToFragmentAsync(JsRuntime);
		}

		protected override void OnInitialized()
		{
			NavigationMgr.LocationChanged += TryFragmentNavigation;
		}
	}
}
