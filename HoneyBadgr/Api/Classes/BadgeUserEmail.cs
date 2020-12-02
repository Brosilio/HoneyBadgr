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
		public string entityType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string entityId { get; set; }

		/// <summary>
		/// Email address associated with a <see cref="BadgeUser"/>
		/// </summary>
		public string email { get; set; }

		/// <summary>
		/// True if the email address has been verified by the user
		/// </summary>
		public bool verified { get; set; }

		/// <summary>
		/// True for a single email address. Is used for email notifications
		/// </summary>
		public bool primary { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string[] caseVariants { get; set; }
	}
}
