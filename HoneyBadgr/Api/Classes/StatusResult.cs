using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api.Classes
{
	public class StatusResult<T> where T : class
	{
		public Status status { get; set; }
		public T result { get; set; }
	}

	public class Status
	{
		public bool success { get; set; }
		public string description { get; set; }
	}
}
