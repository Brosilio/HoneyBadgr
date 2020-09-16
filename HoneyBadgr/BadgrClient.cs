using HoneyBadgr.Api;
using HoneyBadgr.Api.Classes;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HoneyBadgr
{
	public partial class BadgrClient
	{
		private AccessToken authorization;
		private HttpClient client = new HttpClient();


		public BadgrClient() { }

		public BadgrClient(string accessToken)
		{
			authorization = new AccessToken()
			{
				token = accessToken
			};
		}

		public async Task<ApiCallResult<AuthResponse>> GetAccessToken(string username, string password)
		{
			string url = $"{Endpoints.API_AUTH}{Endpoints.API_TOKEN}";
			ApiCallResult<AuthResponse> res = await DoPostAsync<AuthResponse>(url, $"username={username}&password={password}");
			return res;
		}

		private Task<ApiCallResult<T>> DoGetAsync<T>(string uri) where T : class
		{
			return DoRequestAsync<T>("GET", uri, null);
		}

		private Task<ApiCallResult<T>> DoPostAsync<T>(string uri, string body = null) where T : class
		{
			return DoRequestAsync<T>("POST", uri, body);
		}

		private async Task<ApiCallResult<T>> DoRequestAsync<T>(string method, string uri, string body) where T : class
		{
			HttpRequestMessage req = new HttpRequestMessage(new HttpMethod(method), uri);
			client.DefaultRequestHeaders

			if(authorization != null)
				req.Headers["Authorization"] = $"Bearer {authorization.token}";
			req.ContentType = "application/x-www-form-urlencoded";

			if (body != null)
			{
				byte[] data = Encoding.Default.GetBytes(body);
				await req.GetRequestStream().WriteAsync(data, 0, data.Length);
			}

			if (!(await req.GetResponseAsync() is HttpWebResponse httpResponse))
				return null;

			string responseBody = null;
			using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream()))
			{
				responseBody = await reader.ReadToEndAsync();
			}

			Console.WriteLine(responseBody);

			T obj = null;
			if (!string.IsNullOrWhiteSpace(responseBody) && httpResponse.ContentType == "application/json")
			{
				obj = JsonSerializer.Deserialize<T>(responseBody);
			}


			ApiCallResult<T> result = new ApiCallResult<T>((int)httpResponse.StatusCode, obj, responseBody, string.IsNullOrWhiteSpace(responseBody));
			return result;
		}
	}
}
