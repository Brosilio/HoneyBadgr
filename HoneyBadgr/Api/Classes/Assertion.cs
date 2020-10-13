using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class Assertion
	{
		public Assertion()
		{

		}

		public Assertion(BadgeRecipient recipient)
		{
			this.recipient = recipient;
			//this.issuedOn = DateTime.Now;
		}

		public Assertion(string issuerId, BadgeClass badge, BadgeRecipient recipient, string narriative, AssertionEvidence[] evidence, string expires, DateTime issuedOn)
		{
			//this.badgeclass = badge.entityId;
			//this.badgeclassName = badge.name;
			this.badgeclassOpenBadgeId = badge.openBadgeId;
			this.recipient = recipient;
			this.narrative = narrative;
			this.evidence = evidence ?? Array.Empty<AssertionEvidence>();
			this.expires = expires;
			this.issuer = issuerId;
			//this.issuedOn = issuedOn;
		}

		/// <summary>
		/// "Assertion"
		/// </summary>
		public string entityType { get; set; } // TODO: make readonly

		/// <summary>
		/// Unique identifier for this Assertion
		/// </summary>
		public string entityId { get; set; } // TODO: make readonly

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId { get; set; } // TODO: make readonly

		/// <summary>
		/// Timestamp when this <see cref="Assertion"/> was created
		/// </summary>
		public string createdAt { get; set; }

		/// <summary>
		/// The <see cref="BadgeUser"/> that created this <see cref="Assertion"/>
		/// </summary>
		public string createdBy { get; set; }

		/// <summary>
		/// The <see cref="BadgeClass"/> that issued this <see cref="Assertion"/>. May be null.
		/// </summary>
		public string badgeclass { get; set; }

		/// <summary>
		/// URL of the <see cref="BadgeClass"/> to award. May be null.
		/// </summary>
		public string badgeclassOpenBadgeId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string issuer { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string issuerOpenBadgeId { get; set; }

		/// <summary>
		/// URL to the baked assertion image
		/// </summary>
		public string image { get; set; }

		/// <summary>
		/// The recipient of this <see cref="Assertion"/>
		/// </summary>
		public BadgeRecipient recipient { get; set; }

		/// <summary>
		/// Timestamp when this <see cref="Assertion"/> was issued
		/// </summary>
		public string issuedOn { get; set; }

		/// <summary>
		/// Markdown narrative of the achievement
		/// </summary>
		public string narrative { get; set; }

		/// <summary>
		/// List of evidence associated with the achievement
		/// </summary>
		public AssertionEvidence[] evidence { get; set; }

		/// <summary>
		/// True if this Assertion has been revoked
		/// </summary>
		public bool revoked { get; set; }

		/// <summary>
		/// Short description of why the Assertion was revoked
		/// </summary>
		public string revokationReason { get; set; }

		/// <summary>
		/// Timestamp when this <see cref="Assertion"/> expires
		/// </summary>
		public string expires { get; set; } // TODO: turn into datetime or something

		/// <summary>
		/// Name of the <see cref="BadgeClass"/> to create assertion against, case insensitive
		/// </summary>
		public string badgeclassName { get; set; }
	}
}
