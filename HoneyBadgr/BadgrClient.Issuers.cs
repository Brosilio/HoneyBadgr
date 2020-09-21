using HoneyBadgr.Api;
using HoneyBadgr.Api.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HoneyBadgr
{
	public partial class BadgrClient
	{
		/// <summary>
		/// Get a list of <see cref="Issuer"/>s for the authenticated client.
		/// </summary>
		/// <returns></returns>
		public Task<ApiCallResult<Issuer[]>> GetIssuers()
		{
			string uri = $"{Endpoints.API_BASE}/{Endpoints.API_ISSUERS}";

			return DoGetSRAsync<Issuer[]>(uri);
		}

		/// <summary>
		/// Get a list of <see cref="Assertion"/>s for a single <see cref="Issuer"/>.
		/// </summary>
		/// <param name="entityId">The ID of the issuer from which to get assertions</param>
		/// <param name="recipient">The ID of a recipient to filter results by</param>
		/// <param name="num">Request pagination of the results</param>
		/// <param name="includeExpired">Include expired assertions</param>
		/// <param name="includeRevoked">Include revoked assertions</param>
		/// <returns></returns>
		public Task<ApiCallResult<Assertion[]>> GetIssuerAssertions(string entityId, string recipient = null, int num = -1, bool includeExpired = false, bool includeRevoked = false)
		{
			string uri = $"{Endpoints.API_BASE}/{Endpoints.API_ISSUERS}/{entityId}/{Endpoints.API_ASSERTIONS}";
			AppendQuery(uri, "recipient", recipient);
			if (num > -1) AppendQuery(uri, "num", num);
			if (includeExpired) AppendQuery(uri, "include_expired", true);
			if (includeRevoked) AppendQuery(uri, "include_revoked", true);

			return DoGetSRAsync<Assertion[]>(uri);
		}

		/// <summary>
		/// Issue a new <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		/// <param name="entityId">The <see cref="Issuer.entityId" /> issuer ID</param>
		/// <param name="assertion">The recipient's ID</param>
		public async Task<ApiCallResult<BackpackAssertion>> IssueNewAssertion(string entityId, Assertion assertion)
		{
			string uri = $"{Endpoints.API_BASE}/issuers/{entityId}/assertions";
			return await DoPostAsync<BackpackAssertion>(uri, "application/json", JsonSerializer.Serialize<Assertion>(assertion));
		}
	}
}
