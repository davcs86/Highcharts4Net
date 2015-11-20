using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// <p>An array of colored bands stretching across the plot area marking an interval on the axis.</p><p>In a gauge, a plot band on the Y axis (value axis) will stretch along the perimeter of the gauge.</p>
	/// </summary>
	public class XAxisPlotBands
	{

        /// <summary>
        /// Border color for the plot band. Also requires <pre>borderWidth</pre> to be set.
        /// Default: null
        /// </summary>
        public ColorOrGradient BorderColor { get; set; }

        /// <summary>
        /// Border width for the plot band. Also requires <pre>borderColor</pre> to be set.
        /// Default: 0
        /// </summary>
        public HighchartsDataPoint? BorderWidth { get; set; }

		/// <summary>
		/// The color of the plot band.
		/// </summary>
		public ColorOrGradient Color { get; set; }

		/// <summary>
		/// An object defining mouse events for the plot band. Supported properties are <code>click</code>, <code>mouseover</code>, <code>mouseout</code>, <code>mousemove</code>.
		/// </summary>
		public Events Events { get; set; }

		/// <summary>
		/// The start position of the plot band in axis units.
		/// </summary>
		public HighchartsDataPoint? From { get; set; }

		/// <summary>
		/// An id used for identifying the plot band in Axis.removePlotBand.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public XAxisPlotBandsLabel Label { get; set; }

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public HighchartsDataPoint? To { get; set; }

		/// <summary>
		/// The z index of the plot band within the chart.
		/// </summary>
		public HighchartsDataPoint? ZIndex { get; set; }

	}

}