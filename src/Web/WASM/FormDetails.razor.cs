using ClinicAnywhere.WASM.Managers;
using ClinicAnywhere.WASM.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM
{
	public class FormDetailsComponent: ComponentBase
	{
		[Parameter]
		public string FormId { get; set; }

		[Inject]
		private HttpClient client { get; set; }
		[Inject]
		private IAppManager appManager { get; set; }

		protected FormSchemaModel formInfo;

		protected override async Task OnInitializedAsync()
		{
			await this.LoadForm();
		}

		private async Task LoadForm()
		{
			var requestModel = new { FormId = FormId };

			var response = await client.PostAsJsonAsync(appManager.FormApiUrl + "/schema/all", requestModel);
			formInfo = await response.Content.ReadFromJsonAsync<FormSchemaModel>();
		}
	}
}
