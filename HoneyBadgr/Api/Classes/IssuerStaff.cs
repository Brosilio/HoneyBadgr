namespace HoneyBadgr.Api.Classes
{
	public class IssuerStaff
	{
		/// <summary>
		/// "IssuerStaff". Read only.
		/// </summary>
		public string entityType; // TODO: make read only

		/// <summary>
		/// Unique identifier for this <see cref="IssuerStaff"/>. Read only.
		/// </summary>
		public string entityId; // TODO: make read only

		/// <summary>
		/// 
		/// </summary>
		public string userProfile;

		/// <summary>
		/// 
		/// </summary>
		public string user;

		/// <summary>
		/// "staff", "editor", "owner".
		/// </summary>
		public string role; // TODO: convert to enum of some sort
	}
}