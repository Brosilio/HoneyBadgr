using HoneyBadgr.Api;
using HoneyBadgr.Api.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBadgr
{
	public partial class BadgrClient
	{
		/// <summary>
		/// Obtain an auth token using a username and password.
		/// </summary>
		/// <param name="username">Username or email</param>
		/// <param name="password">Password</param>
		/// <returns>An <see cref="AuthResponse"/> possibly containing an auth token.</returns>
		public async Task<ApiCallResult<AuthResponse>> Authenticate(string username, string password)
		{
			string url = $"{Endpoints.API_AUTH}{Endpoints.API_TOKEN}";
			string body = $"username={username}&password={password}";
			string mime = "application/x-www-form-urlencoded";
			ApiCallResult<AuthResponse> res = await DoPostAsync<AuthResponse>(url, mime, body);

			return res;
		}

		/// <summary>
		/// Refreshes an auth token. Set the token to refresh using <see cref="SetAuthToken(string)"/>
		/// </summary>
		/// <param name="refreshToken">The refresh token, used to refresh the bearer token</param>
		/// <returns></returns>
		public async Task<ApiCallResult<object>> RefreshAuthToken(string refreshToken)
		{
			string url = $"{Endpoints.API_AUTH}{Endpoints.API_TOKEN}";
			string body = $"grant_type=refresh_token&refresh_token={refreshToken}";
			string mime = "application/x-www-form-urlencoded";
			ApiCallResult<object> result = await DoPostAsync<object>(url, mime, body);

			return result;
		}

		/// <summary>
		/// Set the auth token for this BadgrClient
		/// </summary>
		/// <param name="token">The authorization token. Obtain one by calling <see cref="Authenticate"/></param>
		public void SetAuthToken(string token)
		{
			authToken = token;
			client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
		}
	}
}
