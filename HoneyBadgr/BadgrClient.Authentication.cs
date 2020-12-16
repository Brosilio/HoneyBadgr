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
		/// Obtain an auth token using a username and password. Will automatically set this <see cref="BadgrClient"/>'s auth token if login is successful.
		/// </summary>
		/// <param name="username">Username or email</param>
		/// <param name="password">Password</param>
		/// <returns>An <see cref="AuthResponse"/> possibly containing an auth token.</returns>
		public async Task<ApiCallResult<AuthResponse>> AuthenticateAsync(string username, string password)
		{
			string uri = $"{Endpoints.API_AUTH}{Endpoints.API_TOKEN}";
			string body = $"username={username}&password={password}";
			string mime = "application/x-www-form-urlencoded";
			ApiCallResult<AuthResponse> res = await DoPostAsync<AuthResponse>(uri, mime, body);
			if (res.Success) SetAuthToken(res.Result.access_token, res.Result.refresh_token);

			return res;
		}

		/// <summary>
		/// Obtain an auth token using a username and password.
		/// </summary>
		/// <param name="username">Username or email</param>
		/// <param name="password">Password</param>
		/// <returns>An <see cref="AuthResponse"/> possibly containing an auth token.</returns>
		public ApiCallResult<AuthResponse> Authenticate(string username, string password)
		{
			return AuthenticateAsync(username, password).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Refreshes an auth token. Set the token to refresh using <see cref="SetAuthToken(string)"/>
		/// </summary>
		/// <param name="refreshToken">The refresh token, used to refresh the bearer token</param>
		/// <returns></returns>
		public async Task<ApiCallResult<AuthResponse>> RefreshAuthTokenAsync(string refreshToken)
		{
			string url = $"{Endpoints.API_AUTH}{Endpoints.API_TOKEN}";
			string body = $"grant_type=refresh_token&refresh_token={refreshToken}";
			string mime = "application/x-www-form-urlencoded";
			ApiCallResult<AuthResponse> res = await DoPostAsync<AuthResponse>(url, mime, body);

			if (res.Success) SetAuthToken(res.Result.access_token, res.Result.refresh_token);

			return res;
		}

		/// <summary>
		/// Refresh the auth token using the currently held refresh token.
		/// </summary>
		public async Task<ApiCallResult<AuthResponse>> RefreshAuthTokenAsync()
		{
			return await RefreshAuthTokenAsync(refreshToken);
		}

		/// <summary>
		/// Refreshes an auth token. Set the token to refresh using <see cref="SetAuthToken(string)"/>
		/// </summary>
		/// <param name="refreshToken">The refresh token, used to refresh the bearer token</param>
		/// <returns></returns>
		public ApiCallResult<AuthResponse> RefreshAuthToken(string refreshToken)
		{
			return RefreshAuthTokenAsync(refreshToken).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Set the auth token for this BadgrClient
		/// </summary>
		/// <param name="token">The authorization token. Obtain one by calling <see cref="AuthenticateAsync"/></param>
		public void SetAuthToken(string token, string refreshToken)
		{
			this.authToken = token;
			this.refreshToken = refreshToken;

			client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
			//client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
		}

		/// <summary>
		/// Clear the auth tokens from the client request headers.
		/// </summary>
		public void ClearTokens()
		{
			client.DefaultRequestHeaders.Authorization = null;
			this.authToken = "";
			this.refreshToken = "";
		}
	}
}
