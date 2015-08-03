/*
 *  Copyright (c) 2014-2015, Facebook, Inc.
 *  All rights reserved.
 *
 *  This source code is licensed under the BSD-style license found in the
 *  LICENSE file in the root directory of this source tree. An additional grant 
 *  of patent rights can be found in the PATENTS file in the same directory.
 */

using System.Web;

namespace Highcharts4Net
{
	/// <summary>
	/// Handles creation and execution of <see cref="IHc4xHandler"/> instances.
	/// </summary>
	public class Hc4xHandlerFactory : IHttpHandler
	{
		/// <summary>
		/// Processes this request
		/// </summary>
		/// <param name="context">The request context</param>
		public void ProcessRequest(HttpContext context)
		{
            var handler = new Hc4xHandler(context.Request,context.Response);
            handler.Execute();
		}

		/// <summary>
		/// Gets a value indicating whether another request can use the <see cref="T:System.Web.IHttpHandler" /> instance.
		/// </summary>
		/// <returns>true if the <see cref="T:System.Web.IHttpHandler" /> instance is reusable; otherwise, false.</returns>
		public bool IsReusable { get { return false; } }
	}
}
