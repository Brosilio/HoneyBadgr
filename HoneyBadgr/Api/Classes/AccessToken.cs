using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api
{
	public class AccessToken
	{
		public string token { get; set; }
		public string issuer { get; set; }
		public string expires { get; set; }
	}
}
