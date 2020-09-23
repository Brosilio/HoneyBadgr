using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class BadgeClass
	{
		/// <summary>
		/// "BadgeClass"
		/// </summary>
		public string entityType { get; set; }

		/// <summary>
		/// Unique identifier for this <see cref="BadgeClass"/>
		/// </summary>
		public string entityId { get; set; }

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId { get; set; }

		/// <summary>
		/// Timestamp when this <see cref="BadgeClass"/> was created
		/// </summary>
		public string createdAt { get; set; }

		/// <summary>
		/// BadgeUser who created this <see cref="BadgeClass"/>
		/// </summary>
		public string createdBy { get; set; }

		/// <summary>
		/// entityId of the <see cref="Issuer"/> who owns this <see cref="BadgeClass"/>
		/// </summary>
		public string issuer { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string issuerOpenBadgeId { get; set; }

		/// <summary>
		/// The name of this <see cref="BadgeClass"/>
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// Base64 encoded string of an image that represents this <see cref="BadgeClass"/>.
		/// </summary>
		public string image { get; set; }

		/// <summary>
		/// The description of this <see cref="BadgeClass"/>
		/// </summary>
		public string description { get; set; }

		/// <summary>
		/// External URL that describes in a human-readable format the criteria for this <see cref="BadgeClass"/>
		/// </summary>
		public string criteriaUrl { get; set; }

		/// <summary>
		/// Markdown formatted description of the criteria
		/// </summary>
		public string criteriaNarrative { get; set; }

		/// <summary>
		/// List of objects describing objectives or educational standards
		/// </summary>
		public BadgeClassAlignment[] alignments { get; set; }

		/// <summary>
		/// List of tags that describe this <see cref="BadgeClass"/>
		/// </summary>
		public string[] tags { get; set; }

		/// <summary>
		/// The expiration for this <see cref="BadgeClass"/>
		/// </summary>
		public BadgeClassExpiration expires { get; set; }

		/// <summary>
		/// 
		/// </summary>
		//public string extensions { get; set; }
	}
}
