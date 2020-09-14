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
		public string entityType; // TODO: make read only

		/// <summary>
		/// Unique identifier for this <see cref="Issuer"/>. Read only.
		/// </summary>
		public string entityId; // TODO: make read only

		/// <summary>
		/// URL of the OpenBadge compliant json
		/// </summary>
		public string openBadgeId;

		/// <summary>
		/// Timestamp when the <see cref="Issuer"/> was created
		/// </summary>
		public string createdAt;

		/// <summary>
		/// <see cref="BadgeUser"/> who created this <see cref="Issuer"/>
		/// </summary>
		public string createdBy;

		/// <summary>
		/// The name of this <see cref="Issuer"/>
		/// </summary>
		public string name;

		/// <summary>
		/// Base64 encoded string of an image that represents this <see cref="Issuer"/>
		/// </summary>
		public string image;

		/// <summary>
		/// Contact email for this <see cref="Issuer"/>
		/// </summary>
		public string email;

		/// <summary>
		/// A short description of this <see cref="Issuer"/>
		/// </summary>
		public string description;

		/// <summary>
		/// a homepage or website associated with this <see cref="Issuer"/>
		/// </summary>
		public string url;

		/// <summary>
		/// Staff associated with this <see cref="Issuer"/>
		/// </summary>
		public IssuerStaff[] staff;

		/// <summary>
		/// 
		/// </summary>
		public string extensions;
		
		/// <summary>
		/// 
		/// </summary>
		public string badgrDomain;
	}
}
