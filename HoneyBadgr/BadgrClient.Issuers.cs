﻿using HoneyBadgr.Api;
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
		/// Get a list of <see cref="Issuer"/>s for the authenticated client.
		/// </summary>
		/// <returns></returns>
		public Task<ApiCallResult<Issuer[]>> GetIssuersAsync()
		{
			string uri = $"{Endpoints.API_BASE}/{Endpoints.API_ISSUERS}";

			return DoGetSRAsync<Issuer[]>(uri);
		}

		/// <summary>
		/// Get a list of <see cref="Issuer"/>s for the authenticated client.
		/// </summary>
		/// <returns></returns>
		public ApiCallResult<Issuer[]> GetIssuers()
		{
			return GetIssuersAsync().GetAwaiter().GetResult();
		}

		/// <summary>
		/// Get a list of <see cref="Assertion"/>s for a single <see cref="Issuer"/>.
		/// </summary>
		/// <param name="issuerId">The ID of the issuer from which to get assertions</param>
		/// <param name="recipient">The ID of a recipient to filter results by</param>
		/// <param name="num">Request pagination of the results</param>
		/// <param name="includeExpired">Include expired assertions</param>
		/// <param name="includeRevoked">Include revoked assertions</param>
		/// <returns></returns>
		public Task<ApiCallResult<Assertion[]>> GetIssuerAssertionsAsync(string issuerId, string recipient = null, int num = -1, bool includeExpired = false, bool includeRevoked = false)
		{
			string uri = $"{Endpoints.API_BASE}/{Endpoints.API_ISSUERS}/{issuerId}/{Endpoints.API_ASSERTIONS}";
			AppendQuery(ref uri, "recipient", recipient);
			if (num > -1) AppendQuery(ref uri, "num", num);
			if (includeExpired) AppendQuery(ref uri, "include_expired", true);
			if (includeRevoked) AppendQuery(ref uri, "include_revoked", true);

			return DoGetSRAsync<Assertion[]>(uri);
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
		public ApiCallResult<Assertion[]> GetIssuerAssertions(string entityId, string recipient = null, int num = -1, bool includeExpired = false, bool includeRevoked = false)
		{
			return GetIssuerAssertionsAsync(entityId, recipient, num, includeExpired, includeRevoked).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Issue a new <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		/// <param name="entityId">The issuer ID</param>
		/// <param name="assertion">A new <see cref="Assertion"/> to issue</param>
		public async Task<ApiCallResult<BackpackAssertion>> IssueNewAssertionAsync(string entityId, Assertion assertion)
		{
			string uri = $"{Endpoints.API_BASE}/issuers/{entityId}/assertions";
			return await DoPostAsync<BackpackAssertion, Assertion>(uri, assertion);
		}

		/// <summary>
		/// Issue a new <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		/// <param name="entityId">The issuer ID</param>
		/// <param name="assertion">A new <see cref="Assertion"/> to issue</param>
		public ApiCallResult<BackpackAssertion> IssueNewAssertion(string entityId, Assertion assertion)
		{
			return IssueNewAssertionAsync(entityId, assertion).GetAwaiter().GetResult();
		}

		// TODO: docs
		public async Task<ApiCallResult<BadgeClass[]>> GetIssuerBadgeClassesAsync(string issuerId)
		{
			string uri = $"{Endpoints.API_BASE}/issuers/{issuerId}/badgeclasses";

			return await DoGetSRAsync<BadgeClass[]>(uri);
		}
	}
}
