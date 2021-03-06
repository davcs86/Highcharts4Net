using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Global options that don't apply to each chart. These options, like the <code>lang</code> options, must be set using the <code>Highcharts.setOptions</code> method.<pre>Highcharts.setOptions({ global: { useUTC: false }});</pre>
	/// </summary>
	public class Global
	{
		/// <summary>
		/// Path to the pattern image required by VML browsers in order to draw radial gradients.
		/// Default: http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png
		/// </summary>
		public string VMLRadialGradientURL { get; set; }

		/// <summary>
		/// The URL to the additional file to lazy load for Android 2.x devices. These devices don't  support SVG, so we download a helper file that contains <a href='http://code.google.com/p/canvg/'>canvg</a>, its dependency rbcolor, and our own CanVG Renderer class. To avoid hotlinking to our site, you can install canvas-tools.js on your own server and change this option accordingly.
		/// Default: http://code.highcharts.com/{version}/modules/canvas-tools.js
		/// </summary>
		public string CanvasToolsURL { get; set; }

		/// <summary>
		/// The timezone offset in minutes. Positive values are west, negative values are east of UTC, as in the ECMAScript <a href='https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Date/getTimezoneOffset'>getTimezoneOffset</a> method. Use this to display UTC based data in a predefined time zone. 
		/// Default: 0
		/// </summary>
		public HighchartsDataPoint? TimezoneOffset { get; set; }

		/// <summary>
		/// Whether to use UTC time for axis scaling, tickmark placement and time display in  <code>Highcharts.dateFormat</code>. Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings. Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required.
		/// Default: true
		/// </summary>
		public bool? UseUTC { get; set; }

	}

}