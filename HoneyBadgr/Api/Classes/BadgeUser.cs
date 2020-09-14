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
		public string entityType;

		/// <summary>
		/// Unique identifier for this <see cref="BadgeUser"/>
		/// </summary>
		public string entityId;

		/// <summary>
		/// The user's first name
		/// </summary>
		public string firstName;

		/// <summary>
		/// The user's last name
		/// </summary>
		public string lastName;

		/// <summary>
		/// The emails the user has provided
		/// </summary>
		public BadgeUserEmail[] emails;

		public string url;
		public string telephone;
		public string agreedTermsVersion;
		public string hasAgreedToLatestTermsVersion;
		public string marketingOptIn;
		public string badgrDomain;
		public string hasPasswordSet;
		public string recipient;
	}
}
