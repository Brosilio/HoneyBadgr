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
		public string entityType;

		/// <summary>
		/// Unique identifier for this <see cref="BadgeClass"/>
		/// </summary>
		public string entityId;

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId;

		/// <summary>
		/// Timestamp when this <see cref="BadgeClass"/> was created
		/// </summary>
		public string createdAt;

		/// <summary>
		/// BadgeUser who created this <see cref="BadgeClass"/>
		/// </summary>
		public string createdBy;

		/// <summary>
		/// entityId of the <see cref="Issuer"/> who owns this <see cref="BadgeClass"/>
		/// </summary>
		public string issuer;

		/// <summary>
		/// 
		/// </summary>
		public string issuerOpenBadgeId;

		/// <summary>
		/// The name of this <see cref="BadgeClass"/>
		/// </summary>
		public string name;

		/// <summary>
		/// Base64 encoded string of an image that represents this <see cref="BadgeClass"/>.
		/// </summary>
		public string image;

		/// <summary>
		/// The description of this <see cref="BadgeClass"/>
		/// </summary>
		public string description;

		/// <summary>
		/// External URL that describes in a human-readable format the criteria for this <see cref="BadgeClass"/>
		/// </summary>
		public string criteriaUrl;

		/// <summary>
		/// Markdown formatted description of the criteria
		/// </summary>
		public string criteriaNarrative;

		/// <summary>
		/// List of objects describing objectives or educational standards
		/// </summary>
		public BadgeClassAlignment[] alignments;

		/// <summary>
		/// List of tags that describe this <see cref="BadgeClass"/>
		/// </summary>
		public string[] tags;

		/// <summary>
		/// The expiration for this <see cref="BadgeClass"/>
		/// </summary>
		public BadgeClassExpiration expires;

		/// <summary>
		/// 
		/// </summary>
		public string extensions;
	}
}
