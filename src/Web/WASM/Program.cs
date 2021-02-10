using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ClinicAnywhere.WASM.Managers;

namespace ClinicAnywhere.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IAppManager>(s => new AppManager 
            { 
                MasterdataApiUrl = "http://localhost:5204/api",
                FormApiUrl = "http://localhost:5203/api"
            });

            builder.Services.AddScoped<IAppUserContext>(s => new AppUserContext());

            await builder.Build().RunAsync();
        }
    }
}
