using HoneyBadgr.Api;
using HoneyBadgr.Api.Classes;
using System;
using System.Net;
using System.Threading.Tasks;

namespace HoneyBadgr
{
	public class BadgrClient
	{
		private WebClient client;

		public BadgrClient()
		{
			this.client = new WebClient();
			HttpWebRequest hwr = HttpWebRequest.
			hwr.
		}

		public async Task<int> RevokeAssertion()
		{
			throw new NotImplementedException();
		}

		public async Task<ApiCallResult<Assertion>> GetSingleAssertion(string entityId)
		{

		}

		public async Task<int>
	}
}
