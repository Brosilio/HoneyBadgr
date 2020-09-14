using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class BadgeUserEmail
	{
		public string entityType;
		public string entityId;

		/// <summary>
		/// Email address associated with a <see cref="BadgeUser"/>
		/// </summary>
		public string email;
		public bool verified;
		public bool primary;
		public string caseVariants;
	}
}
