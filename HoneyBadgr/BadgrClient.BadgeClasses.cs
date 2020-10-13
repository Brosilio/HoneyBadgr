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
		/// Get a list of <see cref="BadgeClass"/>es for the authenticated user.
		/// </summary>
		public async Task<ApiCallResult<BadgeClass[]>> GetBadgeClassesAsync()
		{
			string uri = $"{Endpoints.API_BASE}/badgeclasses";
			return await DoGetSRAsync<BadgeClass[]>(uri);
		}

		/// <summary>
		/// Get a list of <see cref="BadgeClass"/>es for the authenticated user.
		/// </summary>
		public ApiCallResult<BadgeClass[]> GetBadgeClasses()
		{
			return GetBadgeClassesAsync().GetAwaiter().GetResult();
		}

		/// <summary>
		/// Issue an <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		/// <param name="badgeClassId">The ID of the <see cref="BadgeClass"/> to issue</param>
		/// <param name="assertion">An <see cref="Assertion"/> containing the <see cref="BadgeRecipient"/> to issue the badge to.</param>
		public async Task<ApiCallResult<BackpackAssertion>> IssueAssertionAsync(string badgeClassId, Assertion assertion)
		{
			string uri = $"{Endpoints.API_BASE}/badgeclasses/{badgeClassId}/assertions";
			return await DoPostAsync<BackpackAssertion, Assertion>(uri, assertion);
		}

		/// <summary>
		/// Issues an <see cref="Assertion"/> to a single recipient, by email.
		/// </summary>
		/// <param name="badgeClassId">The ID of the badge to issue.</param>
		/// <param name="email">The email of the user to issue.</param>
		public async Task<ApiCallResult<BackpackAssertion>> IssueAssertionToEmailAsync(string badgeClassId, string email)
		{
			BadgeRecipient recipient = new BadgeRecipient()
			{
				hashed = true,
				identity = email,
				type = "email"
			};

			return await IssueAssertionAsync(badgeClassId, new Assertion(recipient));
		}

		/// <summary>
		/// Issue an <see cref="Assertion"/> to a single recipient.
		/// <para>Statuses:</para>
		/// <list type="bullet">
		///		<item>201: Successfully created</item>
		///		<item>400: Validation error</item>
		/// </list>
		/// </summary>
		/// <param name="badgeClassId">The ID of the <see cref="BadgeClass"/> to issue</param>
		/// <param name="assertion">An <see cref="Assertion"/> containing the <see cref="BadgeRecipient"/> to issue the badge to.</param>
		public ApiCallResult<BackpackAssertion> IssueAssertion(string badgeClassId, Assertion assertion)
		{
			return IssueAssertionAsync(badgeClassId, assertion).GetAwaiter().GetResult();
		}
	}
}
