using BlazorMasterDetails.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorMasterDetails.Client.Services
{
	public class CustomerSevice
	{
		private readonly HttpClient http;

		private string apiUrl = "/api/Customers";

		public CustomerSevice(HttpClient http, NavigationManager nav)
		{
			http.BaseAddress = new Uri(nav.BaseUri);
			this.http = http;
		}

		public async Task<IList<Customer>?> GetAll()
		{
			var data = await this.http.GetFromJsonAsync<IList<Customer>>(apiUrl);
			return data;
		}
		public async Task<Customer?> GetById(int id)
		{
			return await this.http.GetFromJsonAsync<Customer>(apiUrl + $"/{id}");
		}
		public async Task<HttpResponseMessage?> Save(Customer data)
		{
			return await this.http.PostAsJsonAsync<Customer>(apiUrl, data);
		}
		public async Task<HttpResponseMessage?> Update(Customer data)
		{
			return await this.http.PutAsJsonAsync<Customer>(apiUrl + $"/{data.CustomerID}", data);
		}

		public async Task<HttpResponseMessage?> Delete(int id)
		{
			return await this.http.DeleteAsync(apiUrl + $"/{id}");
		}
	}
}
