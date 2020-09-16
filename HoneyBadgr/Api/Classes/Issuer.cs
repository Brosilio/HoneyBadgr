using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	/// <summary>
	/// An issuer of badges
	/// </summary>
	public class Issuer
	{
		/// <summary>
		/// "Issuer". Read only.
		/// </summary>
		public string entityType { get; set; } // TODO: make read only

		/// <summary>
		/// Unique identifier for this <see cref="Issuer"/>. Read only.
		/// </summary>
		public string entityId { get; set; } // TODO: make read only

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId { get; set; }

		/// <summary>
		/// Timestamp when the <see cref="Issuer"/> was created
		/// </summary>
		public string createdAt { get; set; }

		/// <summary>
		/// <see cref="BadgeUser"/> who created this <see cref="Issuer"/>
		/// </summary>
		public string createdBy { get; set; }

		/// <summary>
		/// The name of this <see cref="Issuer"/>
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// Base64 encoded string of an image that represents this <see cref="Issuer"/>
		/// </summary>
		public string image { get; set; }

		/// <summary>
		/// Contact email for this <see cref="Issuer"/>
		/// </summary>
		public string email { get; set; }

		/// <summary>
		/// A short description of this <see cref="Issuer"/>
		/// </summary>
		public string description { get; set; }

		/// <summary>
		/// a homepage or website associated with this <see cref="Issuer"/>
		/// </summary>
		public string url { get; set; }

		/// <summary>
		/// Staff associated with this <see cref="Issuer"/>
		/// </summary>
		public IssuerStaff[] staff { get; set; }

		/// <summary>
		/// 
		/// </summary>
		//public string extensions { get; set; }
		
		/// <summary>
		/// 
		/// </summary>
		public string badgrDomain { get; set; }
	}
}
