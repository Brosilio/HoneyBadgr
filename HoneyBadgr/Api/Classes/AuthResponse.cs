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
		public string access_token { get; set; }

		/// <summary>
		/// The type of the access token (probably "Bearer")
		/// </summary>
		public string token_type { get; set; }

		/// <summary>
		/// Seconds until this token expires
		/// </summary>
		public int expires_in { get; set; }

		/// <summary>
		/// The refresh token, used for re-validating the <see cref="access_token"/> to avoid re-entry of username and password
		/// </summary>
		public string refresh_token { get; set; }
	}
}
