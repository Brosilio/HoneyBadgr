namespace HoneyBadgr.Api.Classes
{
	public class IssuerStaff
	{
		/// <summary>
		/// "IssuerStaff". Read only.
		/// </summary>
		public string entityType { get; set; } // TODO: make read only

		/// <summary>
		/// Unique identifier for this <see cref="IssuerStaff"/>. Read only.
		/// </summary>
		public string entityId { get; set; } // TODO: make read only

		/// <summary>
		/// 
		/// </summary>
		//public string userProfile { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string user { get; set; }

		/// <summary>
		/// "staff", "editor", "owner".
		/// </summary>
		public string role { get; set; } // TODO: convert to enum of some sort
	}
}