using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class BadgeUser
	{
		/// <summary>
		/// “BadgeUser”
		/// </summary>
		public string entityType { get; set; }

		/// <summary>
		/// Unique identifier for this <see cref="BadgeUser"/>
		/// </summary>
		public string entityId { get; set; }

		/// <summary>
		/// The user's first name
		/// </summary>
		public string firstName { get; set; }

		/// <summary>
		/// The user's last name
		/// </summary>
		public string lastName { get; set; }

		/// <summary>
		/// The emails the user has provided
		/// </summary>
		public BadgeUserEmail[] emails { get; set; }

		public string[] url { get; set; }
		public string[] telephone { get; set; }
		public string agreedTermsVersion { get; set; }
		public string hasAgreedToLatestTermsVersion { get; set; }
		public string marketingOptIn { get; set; }
		public string badgrDomain { get; set; }
		public string hasPasswordSet { get; set; }
		public BadgeRecipient recipient { get; set; }
	}
}
