using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api
{
	public static class Endpoints
	{
		/// <summary>
		/// The base API endpoint. Change this if you want to use a different server.
		/// </summary>
		public const string API_BASE = "https://api.badgr.io/v2/";

		/// <summary>
		/// The access token endpoint. Change if you want to use a different server.
		/// </summary>
		public const string API_AUTH = "https://api.badgr.io/o/";

		/// <summary>
		/// The endpoint for retrieving an access token with username and password
		/// </summary>
		public const string API_TOKEN = "token";
	}
}
