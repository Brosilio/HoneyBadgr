using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class Collection
	{
		/// <summary>
		/// "Collection"
		/// </summary>
		public string entityType { get; set; }

		/// <summary>
		/// Unique identifier for this <see cref="Collection"/>
		/// </summary>
		public string entityId { get; set; }

		/// <summary>
		/// The name of this <see cref="Collection"/>
		/// </summary>
		public string name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string owner { get; set; }

		/// <summary>
		/// A public URL for sharing the Collection. Read only.
		/// </summary>
		public string share_url { get; set; } // TODO: make read only

		/// <summary>
		/// The share hash that allows construction of a public sharing URL. Read only.
		/// </summary>
		public string shareHash { get; set; } // TODO: make read only

		/// <summary>
		/// True if the Collection has a public share URL
		/// </summary>
		public bool published { get; set; }

		/// <summary>
		/// List of <see cref="Assertion"/>s in this collection
		/// </summary>
		public Assertion[] assertions { get; set; }

		/// <summary>
		/// Timestamp when the <see cref="Collection"/> was created
		/// </summary>
		public string createdAt { get; set; }

		/// <summary>
		/// <see cref="BadgeUser"/> who created this <see cref="Collection"/>
		/// </summary>
		public string createdBy { get; set; }
	}
}
