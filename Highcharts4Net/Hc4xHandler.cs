/*
 *  Copyright (c) 2014-2015, Facebook, Inc.
 *  All rights reserved.
 *
 *  This source code is licensed under the BSD-style license found in the
 *  LICENSE file in the root directory of this source tree. An additional grant 
 *  of patent rights can be found in the PATENTS file in the same directory.
 */

using System.IO;
using System.Reflection;
using System.Web;

namespace Highcharts4Net
{
	/// <summary>
	/// ASP.NET handler that transforms Hc4x into JavaScript.
	/// </summary>
	public sealed class Hc4xHandler
	{
        private readonly HttpRequest _request;
        private readonly HttpResponse _response;

		/// <summary>
		/// Initializes a new instance of the <see cref="Hc4xHandler"/> class.
		/// </summary>
		/// <param name="request">HTTP request</param>
		/// <param name="response">HTTP response</param>
		public Hc4xHandler(
			HttpRequest request,
			HttpResponse response
		)
		{
			_request = request;
			_response = response;
		}

		/// <summary>
		/// Executes the handler. Outputs JavaScript to the response.
		/// </summary>
		public void Execute()
		{
    		RenderHc4xFile();
		}

		/// <summary>
		/// Renders the Hc4x file converted to regular JavaScript.
		/// </summary>
		private void RenderHc4xFile()
		{
		    if (_request.AppRelativeCurrentExecutionFilePath.Equals("~/highcharts.hc4x"))
		    {
                _response.ContentType = "text/javascript";

                var resource = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Highcharts4Net.Scripts.highcharts.js"));

                _response.Write(resource.ReadToEnd());
		    }
			
		}

		
	}
}
