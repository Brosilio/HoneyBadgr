using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class BackpackAssertion
	{
		/// <summary>
		/// "Issuer"
		/// </summary>
		public string entityType; // TODO: make readonly

		/// <summary>
		/// Unique identifier for this Issuer
		/// </summary>
		public string entityId; // TODO: make readonly

		/// <summary>
		/// 
		/// </summary>
		public string acceptance;

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId; // TODO: make readonly

		/// <summary>
		/// The <see cref="BadgeClass"/> that issued this Assertion
		/// </summary>
		public string badgeClass;

		/// <summary>
		/// URL of the BadgeClass to award
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
		/// The recipient that was issued this Assertion
		/// </summary>
		public BadgeRecipient recipient;

		/// <summary>
		/// Timestamp when this Assertion was issued
		/// </summary>
		public string issuedOn; // TODO: turn into datetime object or something

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
		/// Timestamp when this Assertion expires
		/// </summary>
		public string expires; // TODO: turn into datetime object or something

		/// <summary>
		/// 
		/// </summary>
		public string pending;
	}
}
