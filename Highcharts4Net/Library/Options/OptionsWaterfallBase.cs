using System.Drawing;
using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Options for the waterfall series type.
	/// </summary>
	public class OptionsWaterfallBase
	{
		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// Default: false
		/// </summary>
		public bool? AllowPointSelect { get; set; }

		/// <summary>
		/// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href='#chart.animation'>chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href='http://api.jquery.com/animate/'>the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p>
		/// Default: true
		/// </summary>
		//
		public Animation Animation { get; set; }

		/// <summary>
		/// The color of the border of each waterfall column.
		/// Default: #333333
		/// </summary>
		public string BorderColor { get; set; }

		/// <summary>
		/// The corner radius of the border surrounding each column or bar.
		/// Default: 0
		/// </summary>
		public NumberOrDateTime? BorderRadius { get; set; }

		/// <summary>
		/// The width of the border surrounding each column or bar.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? BorderWidth { get; set; }

		/// <summary>
		/// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  <code>options.colors</code> array.
		/// </summary>
		public ColorOrGradient Color { get; set; }

		/// <summary>
		/// When using automatic point colors pulled from the <code>options.colors</code> collection, this option determines whether the chart should receive  one color per series or one color per point.
		/// Default: false
		/// </summary>
		public bool? ColorByPoint { get; set; }

		/// <summary>
		/// A series specific or series type specific color set to apply instead of the global <a href='#colors'>colors</a> when <a href='#plotOptions.column.colorByPoint'>colorByPoint</a> is true.
		/// </summary>
		public Color[] Colors { get; set; }

		/// <summary>
		/// You can set the cursor to 'pointer' if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
		/// </summary>
		public Cursors? Cursor { get; set; }

		/// <summary>
		/// A name for the dash style to use for the line connecting the columns of the waterfall series. Possible values:    <ul>    <li>Solid</li>    <li>ShortDash</li>    <li>ShortDot</li>    <li>ShortDashDot</li>    <li>ShortDashDotDot</li>    <li>Dot</li>    <li>Dash</li>    <li>LongDash</li>    <li>DashDot</li>    <li>LongDashDot</li>    <li>LongDashDotDot</li>    </ul>.
		/// Default: Dot
		/// </summary>
		public DashStyles? DashStyle { get; set; }

		public PlotOptionsWaterfallDataLabels DataLabels { get; set; }

		/// <summary>
		/// Depth of the columns in a 3D column chart. Requires <code>highcharts-3d.js</code>.
		/// Default: 25
		/// </summary>
		public NumberOrDateTime? Depth { get; set; }

		/// <summary>
		/// 3D columns only. The color of the edges. Similar to <code>borderColor</code>, except it defaults to the same color as the column.
		/// </summary>
		public string EdgeColor { get; set; }

		/// <summary>
		/// 3D columns only. The width of the colored edges.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? EdgeWidth { get; set; }

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// Default: true
		/// </summary>
		public bool? EnableMouseTracking { get; set; }

		public PlotOptionsWaterfallEvents Events { get; set; }

        /// <summary>
        /// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
        /// Default: false
        /// </summary>
        public bool? GetExtremesFromAll { get; set; }

        /// <summary>
        /// Padding between each value groups, in x axis units.
        /// Default: 0.2
        /// </summary>
        public NumberOrDateTime? GroupPadding { get; set; }

		/// <summary>
		/// The spacing between columns on the Z Axis in a 3D chart. Requires <code>highcharts-3d.js</code>.
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? GroupZPadding { get; set; }

		/// <summary>
		/// Whether to group non-stacked columns or to let them render independent of each other. Non-grouped columns will be laid out individually and overlap each other.
		/// Default: true
		/// </summary>
		public bool? Grouping { get; set; }

        /// <summary>
        /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
        /// </summary>
        public string[] Keys { get; set; }

        /// <summary>
        /// The color of the line that connects columns in a waterfall series.
        /// Default: #333333
        /// </summary>
        public string LineColor { get; set; }

		/// <summary>
		/// The <a href='#series.id'>id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
		/// </summary>
		public string LinkedTo { get; set; }

		/// <summary>
		/// The minimal height for a column or width for a bar. By default, 0 values are not shown. To visualize a 0 (or close to zero) point, set the minimal point length to a  pixel value like 3. In stacked column charts, minPointLength might not be respected for tightly packed values.
		/// Default: 0
		/// </summary>
		public NumberOrDateTime? MinPointLength { get; set; }

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsWaterfallPoint Point { get; set; }

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>
		/// Default: 1
		/// </summary>
		public NumberOrDateTime? PointInterval { get; set; }

        /// <summary>
        /// <p>On datetime series, this allows for setting the pointInterval to the two irregular time units, month and year. Combine it with pointInterval to draw quarters, 6 months, 10 years etc.</p>
        /// </summary>
        public string PointIntervalUnit { get; set; }

        /// <summary>
        /// Padding between each column or bar, in x axis units.
        /// Default: 0.1
        /// </summary>
        public NumberOrDateTime? PointPadding { get; set; }

		/// <summary>
		/// <p>Possible values: null, 'on', 'between'.</p><p>In a column chart, when pointPlacement is 'on', the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is 'between', the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.</p><p>Defaults to <code>null</code> in cartesian charts, <code>'between'</code> in polar charts.
		/// </summary>
		//
		public PointPlacement PointPlacement { get; set; }

		/// <summary>
		/// The X axis range that each point is valid for. This determines the width of the column. On a categorized axis, the range will be 1 by default (one category unit). On linear and datetime axes, the range will be computed as the distance between the two closest data points.
		/// </summary>
		public NumberOrDateTime? PointRange { get; set; }

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
		/// Default: 0
		/// </summary>
		//
		public NumberOrDateTime? PointStart { get; set; }

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar. When <code>null</code>, the width is calculated from the <code>pointPadding</code> and <code>groupPadding</code>.
		/// </summary>
		public NumberOrDateTime? PointWidth { get; set; }

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// Default: false
		/// </summary>
		public bool? Selected { get; set; }

		/// <summary>
		/// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// Default: false
		/// </summary>
		public bool? Shadow { get; set; }

		/// <summary>
		/// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the <code>selected</code> option.
		/// Default: false
		/// </summary>
		public bool? ShowCheckbox { get; set; }

		/// <summary>
		/// Whether to display this particular series or series type in the legend. The default value is <code>true</code> for standalone series, <code>false</code> for linked series.
		/// Default: true
		/// </summary>
		public bool? ShowInLegend { get; set; }

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsWaterfallStates States { get; set; }

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// Default: true
		/// </summary>
		public bool? StickyTracking { get; set; }

		/// <summary>
		/// The Y axis value to serve as the base for the columns, for distinguishing between values above and below a threshold. If <code>null</code>, the columns extend from the padding Y axis minimum.
		/// Default: 0
		/// </summary>
		[ForceNullable]
		public NumberOrDateTime? Threshold { get; set; }

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href='#tooltip'>tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsWaterfallTooltip Tooltip { get; set; }

		/// <summary>
		/// The color used specifically for positive point columns. When not specified, the general series color is used.
		/// </summary>
		public string UpColor { get; set; }

		/// <summary>
		/// Set the initial visibility of the series.
		/// Default: true
		/// </summary>
		public bool? Visible { get; set; }

        /// <summary>
        /// Defines the Axis on which the zones are applied.
        /// Default: y.
        /// </summary>
        public string ZoneAxis { get; set; }

        /// <summary>
        /// An array defining zones within a series.
        /// </summary>
        public PlotOptionsWaterfallZone[] Zones { get; set; }
    }

}