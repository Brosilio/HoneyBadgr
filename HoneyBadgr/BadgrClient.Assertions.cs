using System;
using System.Collections.Generic;
using System.Text;
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
		/// <param name="entityId">The ID of the <see cref="Assertion"/> to revoke</param>
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
		/// <param name="entityId">The ID of the <see cref="Assertion"/> to revoke</param>
		public async Task<ApiCallResult<Assertion>> GetSingleAssertion(string entityId)
		{
			throw new NotImplementedException();
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
		/// Issue an <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		/// <param name="entityId">The <see cref="Assertion"/> to issue</param>
		/// <param name="assertion">The recipient's ID</param>
		public async Task IssueAssertion(string entityId, Assertion assertion)
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
		/// Get a list of <see cref="Assertion"/>s for a single issuer.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>200: OK</item>
		/// </list>
		/// </summary>
		/// <param name="issuerId">The ID of the issuer</param>
		/// <param name="recipient">A recipient ID to filter by</param>
		/// <param name="num">Request pagination of the results</param>
		/// <param name="includeExpired">Include expired assertions</param>
		/// <param name="includeRevoked">Include revoked assertions</param>
		public async Task<ApiCallResult<Assertion[]>> GetAssertions(string issuerId, string recipient, int num, bool includeExpired, bool includeRevoked)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Issue a new <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		public async Task IssueNewAssertion()
		{

		}
	}
}
