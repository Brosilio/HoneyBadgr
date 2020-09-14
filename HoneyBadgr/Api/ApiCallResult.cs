using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadgr.Api
{
	/// <summary>
	/// The result of a call to the Badgr API.
	/// </summary>
	/// <typeparam name="T">The type of object returned from the API call.</typeparam>
	public class ApiCallResult<T> where T : class
	{
		/// <summary>
		/// The HTTP response code from the API call.
		/// </summary>
		public int ResponseCode { get; }

		/// <summary>
		/// The resulting data from the API call.
		/// </summary>
		public T Result { get; }

		/// <summary>
		/// <see langword="true"/> if the <see cref="ResponseCode"/> is classed as an HTTP "success" status code.
		/// </summary>
		public bool Success
		{
			get
			{
				return ResponseCode >= 200 && ResponseCode < 300;
			}
		}

		public ApiCallResult(int responseCode, T result)
		{
			this.ResponseCode = responseCode;
			this.Result = result;
		}
	}
}
