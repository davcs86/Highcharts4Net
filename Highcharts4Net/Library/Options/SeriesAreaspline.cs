using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// The actual series to append to the chart. In addition to  the members listed below, any member of the <code>plotOptions</code> for that specific type of plot can be added to a series individually. For example, even though a general <code>lineWidth</code> is specified in <code>plotOptions.series</code>, an individual <code>lineWidth</code> can be specified for each series.
	/// </summary>
	public class SeriesAreaspline: OptionsAreasplineBase, ISeries
	{
        public SeriesAreaspline()
        {
            // Sets default values for [ForceNullable] properties
            Threshold = 0;
        }
        /// <summary>
        /// An array of data points for the series. The points can be given in three ways: <ol> <li>An array of numerical values. In this case, the numerical values will  be interpreted as y values, and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from <code>pointStart</code>  and <code>pointInterval</code> given in the plotOptions. If the axis is has categories, these will be used. This option is not available for range series. Example:<pre>data: [0, 5, 3, 5]</pre> </li> <li><p>An array of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.</p><p>For range series, the arrays will be interpreted as <code>[x, low, high]</code>. In this cases, the X value can be skipped altogether to make use of <code>pointStart</code> and <code>pointRange</code>.</p> Example:<pre>data: [[5, 2], [6, 3], [8, 2]]</pre></li><li><p>An array of objects with named values. In this case the objects are point configuration objects as seen below.</p><p>Range series values are given by <code>low</code> and <code>high</code>.</p>Example:<pre>data: [{ name: 'Point 1', color: '#00FF00', y: 0}, { name: 'Point 2', color: '#FF00FF', y: 5}]</pre></li> </ol><p>Note that line series and derived types like spline and area, require data to be sorted by X because it interpolates mouse coordinates for the tooltip. Column and scatter series, where each point has its own mouse event, does not require sorting.</p>
        /// </summary>
        public Data Data { get; set; }

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointer to the series object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the <code>chart.series</code> array, the visible Z index as well as the order in the legend.
		/// </summary>
		public NumberOrDateTime? Index { get; set; }

		/// <summary>
		/// The sequential index of the series in the legend.  <div class='demo'>Try it:  <a href='http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/series/legendindex/' target='_blank'>Legend in opposite order</a> </div>.
		/// </summary>
		public NumberOrDateTime? LegendIndex { get; set; }

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack option can be a string  or a number or anything else, as long as the grouped series' stack options match each other.
		/// </summary>
		public string Stack { get; set; }

		/// <summary>
		/// The type of series. Can be one of <code>area</code>, <code>areaspline</code>, <code>bar</code>, <code>column</code>, <code>line</code>, <code>pie</code>, <code>scatter</code> or <code>spline</code>. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// </summary>
		public ChartTypes Type => ChartTypes.Areaspline;

	    /// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the <a href='#xAxis.id'>axis id</a> or the index of the axis in the xAxis array, with 0 being the first.
		/// Default: 0
		/// </summary>
		public string XAxis { get; set; }

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the <a href='#yAxis.id'>axis id</a> or the index of the axis in the yAxis array, with 0 being the first.
		/// Default: 0
		/// </summary>
		public string YAxis { get; set; }

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public NumberOrDateTime? ZIndex { get; set; }

		public new ColorOrGradient Color { get; set; }

		public string UpColor { get; set; }

	}

}