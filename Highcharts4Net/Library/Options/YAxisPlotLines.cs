using System;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	public class YAxisPlotLines
	{
		/// <summary>
		/// The color of the line.
		/// </summary>
		public ColorOrGradient Color { get; set; }

		/// <summary>
		/// The dashing or dot style for the plot line. For possible values see <a href='http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/'>this overview</a>.
		/// Default: Solid
		/// </summary>
		public DashStyles? DashStyle { get; set; }

		/// <summary>
		/// An object defining mouse events for the plot line. Supported properties are <code>click</code>, <code>mouseover</code>, <code>mouseout</code>, <code>mousemove</code>.
		/// </summary>
		public Object Events { get; set; }

		/// <summary>
		/// An id used for identifying the plot line in Axis.removePlotLine.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public YAxisPlotLinesLabel Label { get; set; }

		/// <summary>
		/// The position of the line in axis units.
		/// </summary>
		public NumberOrDateTime? Value { get; set; }

		/// <summary>
		/// The width or thickness of the plot line.
		/// </summary>
		public NumberOrDateTime? Width { get; set; }

		/// <summary>
		/// The z index of the plot line within the chart.
		/// </summary>
		public NumberOrDateTime? ZIndex { get; set; }

	}

}