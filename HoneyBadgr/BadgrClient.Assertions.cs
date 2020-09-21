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
		public async Task RevokeMultipleAssertions()
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
		public async Task<ApiCallResult<Assertion>> GetSingleAssertion(string entityId)
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
		public async Task RevokeSingleAssertion(string entityId)
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
		public async Task UpdateAssertion(Assertion assertion)
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
		public async Task IssueMultipleAssertions()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Issue an <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		public async Task<ApiCallResult<BackpackAssertion>> IssueAssertion(string issuerId, Assertion assertion)
		{
			string uri = $"{Endpoints.API_BASE}/badgeclasses/{issuerId}/assertions";
			return await DoPostAsync<BackpackAssertion>(uri, "application/json", JsonSerializer.Serialize<Assertion>(assertion));
		}
	}
}
