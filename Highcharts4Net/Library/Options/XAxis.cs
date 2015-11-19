using System;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// <p>The X axis or category axis. Normally this is the horizontal axis, though if the  chart is inverted this is the vertical axis. In case of multiple axes, the xAxis node is an array of configuration objects.</p> <p>See <a class='internal' href='#axis.object'>the Axis object</a> for programmatic access to the axis.</p>
	/// </summary>
	public class XAxis
	{
		/// <summary>
		/// Whether to allow decimals in this axis' ticks. When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels.
		/// Default: true
		/// </summary>
		public bool? AllowDecimals { get; set; }

		/// <summary>
		/// When using an alternate grid color, a band is painted across the plot area between every other grid line.
		/// </summary>
		public string AlternateGridColor { get; set; }

        /// <summary>
        /// <p>If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a <a href='#series.data'>name</a> and setting axis <a href='#xAxis.type'>type</a> to <code>'category'</code>.</p><p>Example:<pre>categories: ['Apples', 'Bananas', 'Oranges']</pre> Defaults to <code>null</code></p>
        /// </summary>
        public AxisBreaks[] Breaks { get; set; }

		/// <summary>
		/// <p>If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a <a href='#series.data'>name</a> and setting axis <a href='#xAxis.type'>type</a> to <code>'category'</code>.</p><p>Example:<pre>categories: ['Apples', 'Bananas', 'Oranges']</pre> Defaults to <code>null</code></p>
		/// </summary>
		public string[] Categories { get; set; }

		/// <summary>
		/// The highest allowed value for automatically computed axis extremes.
		/// </summary>
		public NumberOrDateTime? Ceiling { get; set; }

        /// <summary>
		/// Configure a crosshair that follows either the mouse pointer or the hovered point.
		/// </summary>
		public AxisCrosshair Crosshair { get; set; }

        /// <summary>
        /// For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:<pre>{ millisecond: '%H:%M:%S.%L', second: '%H:%M:%S', minute: '%H:%M', hour: '%H:%M', day: '%e. %b', week: '%e. %b', month: '%b \'%y', year: '%Y'}</pre>
        /// </summary>
        public DateTimeLabel DateTimeLabelFormats { get; set; }

		/// <summary>
		/// Whether to force the axis to end on a tick. Use this option with the <code>maxPadding</code> option to control the axis end.
		/// Default: false
		/// </summary>
		public bool? EndOnTick { get; set; }

		/// <summary>
		/// Event handlers for the axis.
		/// </summary>
		public XAxisEvents Events { get; set; }

		/// <summary>
		/// The lowest allowed value for automatically computed axis extremes.
		/// Default: null
		/// </summary>
		public NumberOrDateTime? Floor { get; set; }

		/// <summary>
		/// Color of the grid lines extending the ticks across the plot area.
		/// Default: #C0C0C0
		/// </summary>
		public string GridLineColor { get; set; }

		/// <summary>
		/// The dash or dot style of the grid lines. For possible values, see <a href='http://jsfiddle.net/gh/get/jquery/1.7.2/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/'>this demonstration</a>.
		/// Default: Solid
		/// </summary>
		public DashStyles? GridLineDashStyle { get; set; }

		/// <summary>
		/// The width of the grid lines extending the ticks across the plot area.
		/// Default: 0
		/// </summary>
		public NumberOrDateTime? GridLineWidth { get; set; }

		/// <summary>
		/// The Z index of the grid lines.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? GridZIndex { get; set; }

		/// <summary>
		/// An id for the axis. This can be used after render time to get a pointer to the axis object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The axis labels show the number or category for each tick.
		/// </summary>
		public XAxisLabels Labels { get; set; }

		/// <summary>
		/// The color of the line marking the axis itself.
		/// Default: #C0D0E0
		/// </summary>
		public string LineColor { get; set; }

		/// <summary>
		/// The width of the line marking the axis itself.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? LineWidth { get; set; }

		/// <summary>
		/// Index of another axis that this axis is linked to. When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes. It can be used to show additional info, or to ease reading the chart by duplicating the scales.
		/// </summary>
		public NumberOrDateTime? LinkedTo { get; set; }

		/// <summary>
		/// The maximum value of the axis. If <code>null</code>, the max value is automatically calculated. If the <code>endOnTick</code> option is true, the <code>max</code> value might be rounded up. The actual maximum value is also influenced by  <a class='internal' href='#chart'>chart.alignTicks</a>.
		/// </summary>
		public NumberOrDateTime? Max { get; set; }

		/// <summary>
		/// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area. When the axis' <code>max</code> option is set or a max extreme is set using <code>axis.setExtremes()</code>, the maxPadding will be ignored.
		/// Default: 0.01
		/// </summary>
		public NumberOrDateTime? MaxPadding { get; set; }

		[Obsolete("Deprecated. Renamed to <code>minRange</code> as of Highcharts 2.2.")]
		public NumberOrDateTime? MaxZoom { get; set; }

		/// <summary>
		/// The minimum value of the axis. If <code>null</code> the min value is automatically calculated. If the <code>startOnTick</code> option is true, the <code>min</code> value might be rounded down.
		/// </summary>
		public NumberOrDateTime? Min { get; set; }

		/// <summary>
		/// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. When the axis' <code>min</code> option is set or a min extreme is set using <code>axis.setExtremes()</code>, the minPadding will be ignored.
		/// Default: 0.01
		/// </summary>
		public NumberOrDateTime? MinPadding { get; set; }

		/// <summary>
		/// <p>The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour.</p> <p>The default minRange for the x axis is five times the smallest interval between any of the data points.</p> <p>On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.</p>
		/// </summary>
		public NumberOrDateTime? MinRange { get; set; }

		/// <summary>
		/// The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours.
		/// </summary>
		public NumberOrDateTime? MinTickInterval { get; set; }

		/// <summary>
		/// Color of the minor, secondary grid lines.
		/// Default: #E0E0E0
		/// </summary>
		public string MinorGridLineColor { get; set; }

		/// <summary>
		/// The dash or dot style of the minor grid lines. For possible values, see <a href='http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/plotoptions/series-dashstyle-all/'>this demonstration</a>.
		/// Default: Solid
		/// </summary>
		public DashStyles? MinorGridLineDashStyle { get; set; }

		/// <summary>
		/// Width of the minor, secondary grid lines.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? MinorGridLineWidth { get; set; }

		/// <summary>
		/// Color for the minor tick marks.
		/// Default: #A0A0A0
		/// </summary>
		public string MinorTickColor { get; set; }

		/// <summary>
		/// <p>Tick interval in scale units for the minor ticks. On a linear axis, if <code>'auto'</code>,  the minor tick interval is calculated as a fifth of the tickInterval. If <code>null</code>, minor ticks are not shown.</p> <p>On logarithmic axes, the unit is the power of the value. For example, setting the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  10 and 100 etc. A minorTickInterval of 'auto' on a log axis results in a best guess, attempting to enter approximately 5 minor ticks between each major tick.</p><p>On axes using <a href='#xAxis.categories'>categories</a>, minor ticks are not supported.</p>
		/// </summary>
		public NumberOrDateTime? MinorTickInterval { get; set; }

		/// <summary>
		/// The pixel length of the minor tick marks.
		/// Default: 2
		/// </summary>
		public NumberOrDateTime? MinorTickLength { get; set; }

		/// <summary>
		/// The position of the minor tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.
		/// Default: outside
		/// </summary>
		public TickPositions? MinorTickPosition { get; set; }

		/// <summary>
		/// The pixel width of the minor tick mark.
		/// Default: 0
		/// </summary>
		public NumberOrDateTime? MinorTickWidth { get; set; }

		/// <summary>
		/// The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area. This is typically used when two or more axes are displayed on the same side of the plot.
		/// Default: 0
		/// </summary>
		public NumberOrDateTime? Offset { get; set; }

		/// <summary>
		/// Whether to display the axis on the opposite side of the normal. The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively. This is typically used with dual or multiple axes.
		/// Default: false
		/// </summary>
		public bool? Opposite { get; set; }

		/// <summary>
		/// <p>An array of colored bands stretching across the plot area marking an interval on the axis.</p><p>In a gauge, a plot band on the Y axis (value axis) will stretch along the perimeter of the gauge.</p>
		/// </summary>
		public XAxisPlotBands[] PlotBands { get; set; }

		/// <summary>
		/// An array of lines stretching across the plot area, marking a specific value on one of the axes.
		/// </summary>
		public XAxisPlotLines[] PlotLines { get; set; }

		/// <summary>
		/// Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.
		/// Default: false
		/// </summary>
		public bool? Reversed { get; set; }

		/// <summary>
		/// Whether to show the axis line and title when the axis has no data.
		/// Default: true
		/// </summary>
		public bool? ShowEmpty { get; set; }

		/// <summary>
		/// Whether to show the first tick label.
		/// Default: true
		/// </summary>
		public bool? ShowFirstLabel { get; set; }

		/// <summary>
		/// Whether to show the last tick label.
		/// Default: true
		/// </summary>
		public bool? ShowLastLabel { get; set; }

		/// <summary>
		/// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
		/// Default: 1
		/// </summary>
		public WeekDays? StartOfWeek { get; set; }

		/// <summary>
		/// Whether to force the axis to start on a tick. Use this option with the <code>maxPadding</code> option to control the axis start.
		/// Default: false
		/// </summary>
		public bool? StartOnTick { get; set; }

		/// <summary>
		/// Color for the main tick marks.
		/// Default: #C0D0E0
		/// </summary>
		public string TickColor { get; set; }

		/// <summary>
		/// <p>The interval of the tick marks in axis units. When <code>null</code>, the tick interval is computed to approximately follow the <a href='#xAxis.tickPixelInterval'>tickPixelInterval</a> on linear and datetime axes. On categorized axes, a <code>null</code> tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as <code>24 * 3600 * 1000</code>.</p> <p>On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.</p>
		/// </summary>
		public NumberOrDateTime? TickInterval { get; set; }

		/// <summary>
		/// The pixel length of the main tick marks.
		/// Default: 10
		/// </summary>
		public NumberOrDateTime? TickLength { get; set; }

		/// <summary>
		/// If tickInterval is <code>null</code> this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis. Defaults to <code>72</code>  for the Y axis and <code>100</code> forthe X axis.
		/// </summary>
		public NumberOrDateTime? TickPixelInterval { get; set; }

		/// <summary>
		/// The position of the major tick marks relative to the axis line. Can be one of <code>inside</code> and <code>outside</code>.
		/// Default: outside
		/// </summary>
		public TickPositions? TickPosition { get; set; }

		/// <summary>
		/// A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of <a href='#xAxis.tickPixelInterval'>tickPixelInterval</a> and <a href='#xAxis.tickInterval'>tickInterval</a>.
		/// </summary>
		
		public string TickPositioner { get; set; }

		/// <summary>
		/// An array defining where the ticks are laid out on the axis. This overrides the default behaviour of <a href='#xAxis.tickPixelInterval'>tickPixelInterval</a> and <a href='#xAxis.tickInterval'>tickInterval</a>.
		/// </summary>
		public NumberOrDateTime?[] TickPositions { get; set; }

		/// <summary>
		/// The pixel width of the major tick marks.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? TickWidth { get; set; }

		/// <summary>
		/// For categorized axes only. If 'on' the tick mark is placed in the center of  the category, if 'between' the tick mark is placed between categories.
		/// Default: between
		/// </summary>
		public Placement? TickmarkPlacement { get; set; }

		/// <summary>
		/// The axis title, showing next to the axis line.
		/// </summary>
		public XAxisTitle Title { get; set; }

		/// <summary>
		/// The type of axis. Can be one of <code>'linear'</code>, <code>'logarithmic'</code>, <code>'datetime'</code> or <code>'category'</code>. In a datetime axis, the numbers are given in milliseconds, and tick marks are placed on appropriate values like full hours or days. In a category axis, the <a href='#series.data'>point names</a> of the chart's series are used for categories, if not a <a href='#xAxis.categories'>categories</a> array is defined.
		/// Default: linear
		/// </summary>
		public AxisTypes? Type { get; set; }

        /// <summary>
        /// Datetime axis only. An array determining what time intervals the ticks are allowed to fall on. Each array item is an array where the first value is the time unit and the second value another array of allowed multiples.
        /// </summary>
        //[JsonFormatter("[{0}, {1}]")]
        public AxisUnits Units { get; set; }

	}

}