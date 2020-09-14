using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class BadgeUserEmail
	{
		/// <summary>
		/// 
		/// </summary>
		public string entityType;

		/// <summary>
		/// 
		/// </summary>
		public string entityId;

		/// <summary>
		/// Email address associated with a <see cref="BadgeUser"/>
		/// </summary>
		public string email;

		/// <summary>
		/// True if the email address has been verified by the user
		/// </summary>
		public bool verified;

		/// <summary>
		/// True for a single email address. Is used for email notifications
		/// </summary>
		public bool primary;

		/// <summary>
		/// 
		/// </summary>
		public string caseVariants;
	}
}
