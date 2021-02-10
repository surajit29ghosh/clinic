using ClinicAnywhere.WASM.Managers;
using ClinicAnywhere.WASM.Models;
using ClinicAnywhere.WASM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ClinicAnywhere.WASM.Pages.Doctor
{
	public class PatientComponent: CAComponentBase
	{
		[Parameter]
		public string PatientId { get; set; }

		protected PatientDetailsModel patientDetails; 

		protected override async Task OnInitializedAsync()
		{
			await this.LoadPatientDetails();
		}

		private async Task LoadPatientDetails()
		{
			var requestModel = new { DoctorId = userContext.DoctorId, PatientId = this.PatientId };

			var response = await client.PostAsJsonAsync(appManager.MasterdataApiUrl + "/patient/details", requestModel);
			patientDetails = await response.Content.ReadFromJsonAsync<PatientDetailsModel>();
		}

		protected async Task LoadFormsOfVisit(string visitId)
		{

		}
	}
}
