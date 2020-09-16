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
		public string entityType { get; set; } // TODO: make readonly

		/// <summary>
		/// Unique identifier for this Issuer
		/// </summary>
		public string entityId { get; set; } // TODO: make readonly

		/// <summary>
		/// 
		/// </summary>
		public string acceptance { get; set; }

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId { get; set; } // TODO: make readonly

		/// <summary>
		/// The <see cref="BadgeClass"/> that issued this Assertion
		/// </summary>
		public string badgeClass { get; set; }

		/// <summary>
		/// URL of the BadgeClass to award
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
		/// The recipient that was issued this Assertion
		/// </summary>
		public BadgeRecipient recipient { get; set; }

		/// <summary>
		/// Timestamp when this Assertion was issued
		/// </summary>
		public string issuedOn { get; set; } // TODO: turn into datetime object or something

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
		/// Timestamp when this Assertion expires
		/// </summary>
		public string expires { get; set; } // TODO: turn into datetime object or something

		/// <summary>
		/// 
		/// </summary>
		public string pending { get; set; }
	}
}
