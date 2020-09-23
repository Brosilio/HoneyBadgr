using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HoneyBadgr.Api;
using HoneyBadgr.Api.Classes;

namespace HoneyBadgr
{
    public partial class BadgrClient
    {
		/// <summary>
		/// Revoke multiple <see cref="Assertion"/>s.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		public async Task RevokeMultipleAssertionsAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get a single <see cref="Assertion"/>.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>200: OK</item>
		///		<item>404: Assertion not found</item>
		/// </list>
		/// </summary>
		/// <param name="entityId">The ID of the <see cref="Assertion"/> to get</param>
		public async Task<ApiCallResult<Assertion>> GetSingleAssertionAsync(string entityId)
		{
			string url = $"{Endpoints.API_BASE}/{Endpoints.API_ASSERTIONS}/{entityId}";
			return await DoGetSRAsync<Assertion>(url);
		}

		/// <summary>
		/// Revoke a single <see cref="Assertion"/>.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>204: Assertion was deleted successfully</item>
		///		<item>400: Assertion is already revoked</item>
		///		<item>404: Assertion not found</item>
		/// </list>
		/// </summary>
		/// <param name="entityId">The ID of the <see cref="Assertion"/> to revoke</param>
		public async Task RevokeSingleAssertionAsync(string entityId)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Update a single <see cref="Assertion"/>.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>200: Successfully updated</item>
		///		<item>400: Validation error</item>
		///		<item>404: Assertion not found</item>
		/// </list>
		/// </summary>
		/// <param name="assertion">The assertion to update.</param>
		public async Task UpdateAssertionAsync(Assertion assertion)
		{
			throw new NotImplementedException();
		}


		/// <summary>
		/// Issue multiple copies of the same <see cref="BadgeClass"/> to multiple <see cref="BadgeRecipient"/>s.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		public async Task IssueMultipleAssertionsAsync()
		{
			throw new NotImplementedException();
		}
	}
}
