using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HoneyBadgr.Api.Classes
{
	public class Collection
	{
		/// <summary>
		/// "Collection"
		/// </summary>
		public string entityType;

		/// <summary>
		/// Unique identifier for this <see cref="Collection"/>
		/// </summary>
		public string entityId;

		/// <summary>
		/// The name of this <see cref="Collection"/>
		/// </summary>
		public string name;

		/// <summary>
		/// 
		/// </summary>
		public string owner;

		/// <summary>
		/// A public URL for sharing the Collection. Read only.
		/// </summary>
		public string share_url; // TODO: make read only

		/// <summary>
		/// The share hash that allows construction of a public sharing URL. Read only.
		/// </summary>
		public string shareHash; // TODO: make read only

		/// <summary>
		/// True if the Collection has a public share URL
		/// </summary>
		public bool published;

		/// <summary>
		/// List of <see cref="Assertion"/>s in this collection
		/// </summary>
		public Assertion[] assertions;

		/// <summary>
		/// Timestamp when the <see cref="Collection"/> was created
		/// </summary>
		public string createdAt;

		/// <summary>
		/// <see cref="BadgeUser"/> who created this <see cref="Collection"/>
		/// </summary>
		public string createdBy;
	}
}
