using ClinicAnywhere.WASM.Managers;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ClinicAnywhere.WASM.Models;

namespace ClinicAnywhere.WASM.Pages.Doctor
{
	public class FormsComponent : ComponentBase
	{
		[Inject]
		private HttpClient client { get; set; }
		[Inject]
		private IAppManager appManager { get; set; }

		[Inject]
		public IAppUserContext userContext { get; set; }

		protected List<FormInfoModel> forms;

		protected override async Task OnInitializedAsync()
		{
			await this.LoadAllForms();
		}

		private async Task LoadAllForms()
		{
			var requestModel = new { DoctorId = userContext.DoctorId };

			var response = await client.PostAsJsonAsync(appManager.FormApiUrl + "/form/all", requestModel);
			forms = await response.Content.ReadFromJsonAsync<List<FormInfoModel>>();
		}
	}
}
