using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class Assertion
	{
		/// <summary>
		/// "Assertion"
		/// </summary>
		public string entityType; // TODO: make readonly

		/// <summary>
		/// Unique identifier for this Assertion
		/// </summary>
		public string entityId; // TODO: make readonly

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId; // TODO: make readonly

		/// <summary>
		/// Timestamp when this <see cref="Assertion"/> was created
		/// </summary>
		public string createdAt;

		/// <summary>
		/// The <see cref="BadgeUser"/> that created this <see cref="Assertion"/>
		/// </summary>
		public string createdBy;

		/// <summary>
		/// The <see cref="BadgeClass"/> that issued this <see cref="Assertion"/>. May be null.
		/// </summary>
		public string badgeclass;

		/// <summary>
		/// URL of the <see cref="BadgeClass"/> to award. May be null.
		/// </summary>
		public string badgeclassOpenBadgeId;

		/// <summary>
		/// 
		/// </summary>
		public string issuer;

		/// <summary>
		/// 
		/// </summary>
		public string issuerOpenBadgeId;

		/// <summary>
		/// URL to the baked assertion image
		/// </summary>
		public string image;

		/// <summary>
		/// The recipient of this <see cref="Assertion"/>
		/// </summary>
		public BadgeRecipient recipient;

		/// <summary>
		/// Timestamp when this <see cref="Assertion"/> was issued
		/// </summary>
		public string issuedOn;

		/// <summary>
		/// Markdown narrative of the achievement
		/// </summary>
		public string narrative;

		/// <summary>
		/// List of evidence associated with the achievement
		/// </summary>
		public AssertionEvidence[] evidence;

		/// <summary>
		/// True if this Assertion has been revoked
		/// </summary>
		public bool revoked;

		/// <summary>
		/// Short description of why the Assertion was revoked
		/// </summary>
		public string revokationReason;

		/// <summary>
		/// Timestamp when this <see cref="Assertion"/> expires
		/// </summary>
		public string expires; // TODO: turn into datetime or something

		/// <summary>
		/// Name of the <see cref="BadgeClass"/> to create assertion against, case insensitive
		/// </summary>
		public string badgeclassName;
	}
}
