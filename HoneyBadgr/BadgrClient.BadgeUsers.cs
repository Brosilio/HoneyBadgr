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
		/// Get a single <see cref="BadgeUser"/> by their user ID.
		/// </summary>
		/// <param name="userId">The ID of the user. Use "self" to get the currently authenticated user.</param>
		public async Task<ApiCallResult<BadgeUser[]>> GetBadgeUserAsync(string userId)
		{
			string uri = $"{Endpoints.API_BASE}/users/{userId}";
			return await DoGetSRAsync<BadgeUser[]>(uri);
		}

		/// <summary>
		/// Get a single <see cref="BadgeUser"/> by their user ID.
		/// </summary>
		/// <param name="userId">The ID of the user. use "self" to get the currently authenticated user.</param>
		public ApiCallResult<BadgeUser[]> GetBadgeUser(string userId)
		{
			return GetBadgeUserAsync(userId).GetAwaiter().GetResult();
		}
	}
}
