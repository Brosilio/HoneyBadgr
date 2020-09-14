using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class BadgeRecipient
	{
		/// <summary>
		/// Either the hash of the identity or the plaintext value
		/// </summary>
		public string identity;

		/// <summary>
		/// Whether or not the identity value is hashed.
		/// </summary>
		public bool hashed;

		/// <summary>
		/// "email", "openBadgeId", "telephone", "url"
		/// </summary>
		public string type; // TODO: convert to enum

		/// <summary>
		/// The plaintext identity
		/// </summary>
		public string plaintextIdentity;
	}
}
