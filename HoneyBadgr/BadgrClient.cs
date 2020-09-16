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
		private string authToken;
		private HttpClient client;

		public BadgrClient()
		{
			client = new HttpClient();
		}

		private string MakeQueryString(string uri, params string[] queries)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(uri);

			if (queries.Length == 0)
				return sb.ToString();

			sb.Append("?");
			for(int i = 0; i < queries.Length; i++)
			{
				sb.Append(queries[i]);

				if(i < queries.Length)
					sb.Append("&");
			}

			return sb.ToString();
		}

		private string AppendQuery(string uri, string param, object value)
		{
			if (param == null || value == null)
				return uri;

			if (!uri.EndsWith("&"))
				uri += "&";

			return uri + $"{param}={value.ToString()}";
		}

		private Task<ApiCallResult<T>> DoGetAsync<T>(string uri) where T : class
		{
			return DoRequestAsync<T>("GET", uri, null, null);
		}

		private async Task<ApiCallResult<T>> DoGetSRAsync<T>(string uri) where T : class
		{
			var sr = await DoGetAsync<StatusResult<T>>(uri);
			return new ApiCallResult<T>(sr.ResponseCode, sr.Result.result, sr.RawResult, sr.IsEmpty);
		}

		private Task<ApiCallResult<T>> DoPostAsync<T>(string uri, string mimeType, string body = null) where T : class
		{
			return DoRequestAsync<T>("POST", uri, body, mimeType);
		}

		private async Task<ApiCallResult<T>> DoRequestAsync<T>(string method, string uri, string body, string mimeType = "application/json") where T : class
		{
			HttpRequestMessage req = new HttpRequestMessage(new HttpMethod(method), uri);

			if (body != null)
			{
				req.Content = new StringContent(body);
				req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mimeType);
			}

			HttpResponseMessage hrm = await client.SendAsync(req);
			string responseBody = await hrm.Content.ReadAsStringAsync();

			T obj = null;
			string mType = hrm.Content.Headers.ContentType.MediaType?.ToLower();
			if (!string.IsNullOrWhiteSpace(responseBody) && (mType == "application/json" || mType == "application/ld+json"))
			{
				obj = JsonSerializer.Deserialize<T>(responseBody);
			}

			Console.WriteLine($"type: {typeof(T)}");

			ApiCallResult<T> result = new ApiCallResult<T>((int)hrm.StatusCode, obj, responseBody, string.IsNullOrWhiteSpace(responseBody));
			return result;
		}
	}
}
