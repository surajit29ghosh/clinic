using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using ClinicAnywhere.WASM.Managers;
using ClinicAnywhere.WASM.Models;
using System.Net.Http;
using ClinicAnywhere.WASM.Shared;

namespace ClinicAnywhere.WASM.Pages.Doctor
{
	public class HomeComponent: CAComponentBase
	{
		protected DoctorModel doctorDetails;

		protected List<PatientModel> patientList;

		protected override async Task OnInitializedAsync()
		{
			await this.LoadDoctorDetails();

			await this.LoadPatientList();
		}

		private async Task LoadDoctorDetails()
		{
			var requestModel = new { DoctorId = userContext.DoctorId };

			var response = await client.PostAsJsonAsync(appManager.MasterdataApiUrl + "/doctor/details", requestModel);
			doctorDetails = await response.Content.ReadFromJsonAsync<DoctorModel>();
		}

		private async Task LoadPatientList()
		{
			var requestModel = new 
			{ 
				DoctorId = userContext.DoctorId,
				page = new 
				{
					PageNumber = 1,
					PageSize = 10
				}
			};

			var response = await client.PostAsJsonAsync(appManager.MasterdataApiUrl + "/patient/all", requestModel);
			patientList = await response.Content.ReadFromJsonAsync<List<PatientModel>>();
		}
	}
}
