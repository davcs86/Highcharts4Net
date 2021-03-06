using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	public class YAxisPlotBands
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
		/// In a gauge chart, this option determines the inner radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like <code>'100%'</code>, or as a pixel number, like <code>100</code>. By default, the inner radius is controlled by the <a href='#yAxis.plotBands.thickness'>thickness</a> option.
		/// Default: null
		/// </summary>
		////[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		//public PercentageOrPixel InnerRadius { get; set; }

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotBandsLabel Label { get; set; }

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like <code>'100%'</code>, or as a pixel number, like <code>100</code>.
		/// Default: 100%
		/// </summary>
		////[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		//public PercentageOrPixel OuterRadius { get; set; }

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretching along the perimeter. It can be given as a percentage string, like <code>'10%'</code>, or as a pixel number, like <code>10</code>. The default value 10 is the same as the default <a href='#yAxis.tickLength'>tickLength</a>, thus making the plot band act as a background for the tick markers. 
		/// Default: 10
		/// </summary>
		////[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		//public PercentageOrPixel Thickness { get; set; }

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