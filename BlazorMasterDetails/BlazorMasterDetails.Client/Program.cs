using BlazorMasterDetails.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorMasterDetails.Client
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);

			builder.Services.AddScoped(sp => new HttpClient());
			builder.Services.AddScoped<CustomerSevice>();

			await builder.Build().RunAsync();
		}
	}
}
