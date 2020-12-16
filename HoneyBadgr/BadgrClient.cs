using HoneyBadgr.Api;
using HoneyBadgr.Api.Classes;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace HoneyBadgr
{
	public partial class BadgrClient
	{
		private readonly HttpClient client;
		private string refreshToken;
		private string authToken;

		/// <summary>
		/// The refresh token for this client, if any.
		/// </summary>
		public string RefreshToken => refreshToken;

		/// <summary>
		/// The auth token for this client, if any.
		/// </summary>
		public string AuthToken => authToken;

		public BadgrClient()
		{
			client = new HttpClient();
			var f = client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "curl/7.64.0");
		}

		private string MakeQueryString(string uri, params string[] queries)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(uri);

			if (queries.Length == 0)
				return sb.ToString();

			sb.Append("?");
			for (int i = 0; i < queries.Length; i++)
			{
				sb.Append(queries[i]);

				if (i < queries.Length)
					sb.Append("&");
			}

			return sb.ToString();
		}

		private void AppendQuery(ref string uri, string param, object value)
		{
			if (param == null || value == null)
				return;

			if (!uri.Contains("?"))
				uri += "?";

			if (!uri.EndsWith("&"))
				uri += "&";

			uri += $"{param}={value}";
		}


		/// <summary>
		/// Perform a GET request to the specified URI and deserialize the result into the specified type
		/// </summary>
		/// <typeparam name="T">The type to deserialize</typeparam>
		/// <param name="uri">The URI of the resource</param>
		/// <returns></returns>
		private Task<ApiCallResult<T>> DoGetAsync<T>(string uri) where T : class
		{
			return DoRequestAsync<T>("GET", uri, null, null);
		}

		/// <summary>
		/// Similar to <see cref="DoGetAsync{T}(string)"/>, except it unwraps a hidden, undocumented <see cref="StatusResult{T}"/>
		/// because Badgr.io sucks and doesn't tell you about it
		/// </summary>
		/// <typeparam name="T">The type to deserialize</typeparam>
		/// <param name="uri">The URI of the resource</param>
		/// <returns></returns>
		private async Task<ApiCallResult<T>> DoGetSRAsync<T>(string uri) where T : class
		{
			var sr = await DoGetAsync<StatusResult<T>>(uri);
			return new ApiCallResult<T>(sr.ResponseCode, sr.Result?.result, sr.RawResult, sr.IsEmpty);
		}

		/// <summary>
		/// Perform a POST request to the specified URI and deserialize the result into an instance of the specified type
		/// </summary>
		/// <typeparam name="TResult">The type of the result</typeparam>
		/// <param name="uri">The URI of the resource</param>
		/// <param name="body">The content of the body. May be null.</param>
		/// <returns></returns>
		private Task<ApiCallResult<TResult>> DoPostAsync<TResult, TBody>(string uri, TBody body)
			where TResult : class
			where TBody : class
		{
			JsonSerializerSettings jso = new JsonSerializerSettings()
			{
				NullValueHandling = NullValueHandling.Ignore
			};

			return DoRequestAsync<TResult>("POST", uri, JsonConvert.SerializeObject(body, jso), "application/json");
		}

		private Task<ApiCallResult<T>> DoPostAsync<T>(string uri, string mimeType, string body) where T : class
		{
			return DoRequestAsync<T>("POST", uri, body, mimeType);
		}

		private async Task<ApiCallResult<T>> DoRequestAsync<T>(string method, string uri, string body, string mimeType) where T : class
		{
			HttpRequestMessage req = new HttpRequestMessage(new HttpMethod(method), uri);

			if (body != null)
			{
				req.Content = new StringContent(body);
				req.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mimeType ?? "application/json");
			}

			HttpResponseMessage hrm = await client.SendAsync(req);
			string responseBody = await hrm.Content.ReadAsStringAsync();

			T obj = null;
			string mType = hrm.Content.Headers.ContentType.MediaType?.ToLower();
			if (!string.IsNullOrWhiteSpace(responseBody) && (mType == "application/json" || mType == "application/ld+json"))
			{
				obj = JsonConvert.DeserializeObject<T>(responseBody);
			}

			ApiCallResult<T> result = new ApiCallResult<T>((int)hrm.StatusCode, obj, responseBody, string.IsNullOrWhiteSpace(responseBody));
			return result;
		}
	}
}
