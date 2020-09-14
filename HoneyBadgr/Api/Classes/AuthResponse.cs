using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class AuthResponse
	{
		/// <summary>
		/// The access token
		/// </summary>
		public string accessToken;

		/// <summary>
		/// The type of the access token (probably "Bearer")
		/// </summary>
		public string tokenType;

		/// <summary>
		/// Seconds until this token expires
		/// </summary>
		public int expiresInSeconds;

		/// <summary>
		/// The refresh token, used for re-validating the <see cref="accessToken"/> to avoid re-entry of username and password
		/// </summary>
		public string refreshToken;
	}
}
