using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Error bars are a graphical representation of the variability of data and are used on graphs to indicate the error, or uncertainty in a reported measurement. 
	/// </summary>
	public class OptionsErrorbarBase
    {
		/// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// Default: false
		/// </summary>
		public bool? AllowPointSelect { get; set; }

		/// <summary>
		/// The main color of the bars. This can be overridden by <a href='#plotOptions.errorbar.stemColor'>stemColor</a> and <a href='#plotOptions.errorbar.whiskerColor'>whiskerColor</a> individually. 
		/// Default: #000000
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
		/// Depth of the columns in a 3D column chart. Requires <code>highcharts-3d.js</code>.
		/// Default: 25
		/// </summary>
		public HighchartsDataPoint? Depth { get; set; }

		/// <summary>
		/// 3D columns only. The color of the edges. Similar to <code>borderColor</code>, except it defaults to the same color as the column.
		/// </summary>
		public string EdgeColor { get; set; }

		/// <summary>
		/// 3D columns only. The width of the colored edges.
		/// Default: 1
		/// </summary>
		public HighchartsDataPoint? EdgeWidth { get; set; }

		/// <summary>
		/// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
		/// Default: true
		/// </summary>
		public bool? EnableMouseTracking { get; set; }

		public PlotOptionsErrorbarEvents Events { get; set; }
        
        /// <summary>
        /// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
        /// Default: false
        /// </summary>
        public bool? GetExtremesFromAll { get; set; }

        /// <summary>
        /// The spacing between columns on the Z Axis in a 3D chart. Requires <code>highcharts-3d.js</code>.
        /// Default: 1
        /// </summary>
        public HighchartsDataPoint? GroupZPadding { get; set; }

        /// <summary>
        /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
        /// </summary>
        public string[] Keys { get; set; }

        /// <summary>
        /// The width of the line surrounding the box. If any of <a href='#plotOptions.boxplot.stemWidth'>stemWidth</a>, <a href='#plotOptions.boxplot.medianWidth'>medianWidth</a> or <a href='#plotOptions.boxplot.whiskerWidth'>whiskerWidth</a> are <code>null</code>, the lineWidth also applies to these lines.
        /// Default: 1
        /// </summary>
        public HighchartsDataPoint? LineWidth { get; set; }

		/// <summary>
		/// The parent series of the error bar. The default value links it to the previous series. Otherwise, use the id of the parent series.
		/// Default: :previous
		/// </summary>
		public string LinkedTo { get; set; }

		/// <summary>
		/// The color for the parts of the graph or points that are below the <a href='#plotOptions.series.threshold'>threshold</a>.
		/// Default: null
		/// </summary>
		public string NegativeColor { get; set; }

		/// <summary>
		/// Properties for each single point
		/// </summary>
		public PlotOptionsErrorbarPoint Point { get; set; }

		/// <summary>
		/// <p>If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.</p>
		/// Default: 1
		/// </summary>
		public HighchartsDataPoint? PointInterval { get; set; }

        /// <summary>
        /// <p>On datetime series, this allows for setting the pointInterval to the two irregular time units, month and year. Combine it with pointInterval to draw quarters, 6 months, 10 years etc.</p>
        /// </summary>
        public string PointIntervalUnit { get; set; }

        /// <summary>
        /// Padding between each column or bar, in x axis units.
        /// Default: 0.1
        /// </summary>
        public HighchartsDataPoint? PointPadding { get; set; }

		/// <summary>
		/// <p>Possible values: null, 'on', 'between'.</p><p>In a column chart, when pointPlacement is 'on', the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is 'between', the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.</p><p>Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.</p><p>Defaults to <code>null</code> in cartesian charts, <code>'between'</code> in polar charts.
		/// </summary>
		//
		public PointPlacement PointPlacement { get; set; }

		/// <summary>
		/// The X axis range that each point is valid for. This determines the width of the column. On a categorized axis, the range will be 1 by default (one category unit). On linear and datetime axes, the range will be computed as the distance between the two closest data points.
		/// </summary>
		public HighchartsDataPoint? PointRange { get; set; }

		/// <summary>
		/// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
		/// Default: 0
		/// </summary>
		//
		public HighchartsDataPoint? PointStart { get; set; }

		/// <summary>
		/// A pixel value specifying a fixed width for each column or bar. When <code>null</code>, the width is calculated from the <code>pointPadding</code> and <code>groupPadding</code>.
		/// </summary>
		public HighchartsDataPoint? PointWidth { get; set; }

		/// <summary>
		/// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
		/// Default: false
		/// </summary>
		public bool? Selected { get; set; }

		/// <summary>
		/// A wrapper object for all the series options in specific states.
		/// </summary>
		public PlotOptionsErrorbarStates States { get; set; }

		/// <summary>
		/// The color of the stem, the vertical line extending from the box to the whiskers. If <code>null</code>, the series color is used.
		/// Default: null
		/// </summary>
		public string StemColor { get; set; }

		/// <summary>
		/// The dash style of the stem, the vertical line extending from the box to the whiskers.
		/// Default: Solid
		/// </summary>
		public DashStyles? StemDashStyle { get; set; }

		/// <summary>
		/// The width of the stem, the vertical line extending from the box to the whiskers. If <code>null</code>, the width is inherited from the <a href='#plotOptions.boxplot.lineWidth'>lineWidth</a> option.
		/// Default: null
		/// </summary>
		public HighchartsDataPoint? StemWidth { get; set; }

		/// <summary>
		/// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
		/// Default: true
		/// </summary>
		public bool? StickyTracking { get; set; }

		/// <summary>
		/// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href='#tooltip'>tooltip</a>, but only the following properties can be defined on a series level.
		/// </summary>
		public PlotOptionsErrorbarTooltip Tooltip { get; set; }

		/// <summary>
		/// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to <code>0</code> disable.
		/// Default: 1000
		/// </summary>
		public HighchartsDataPoint? TurboThreshold { get; set; }

		/// <summary>
		/// Set the initial visibility of the series.
		/// Default: true
		/// </summary>
		public bool? Visible { get; set; }

		/// <summary>
		/// The color of the whiskers, the horizontal lines marking low and high values. When <code>null</code>, the general series color is used.
		/// Default: null
		/// </summary>
		public string WhiskerColor { get; set; }

		/// <summary>
		/// The length of the whiskers, the horizontal lines marking low and high values. It can be a numerical pixel value, or a percentage value of the box width. Set <code>0</code> to disable whiskers.
		/// Default: 50%
		/// </summary>
		//[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public PercentageOrPixel WhiskerLength { get; set; }

		/// <summary>
		/// The line width of the whiskers, the horizontal lines marking low and high values. When <code>null</code>, the general <a href='#plotOptions.errorbar.lineWidth'>lineWidth</a> applies.
		/// Default: null
		/// </summary>
		public HighchartsDataPoint? WhiskerWidth { get; set; }

        /// <summary>
        /// Defines the Axis on which the zones are applied.
        /// Default: y.
        /// </summary>
        public string ZoneAxis { get; set; }

        /// <summary>
        /// An array defining zones within a series.
        /// </summary>
        public PlotOptionsErrorbarZone[] Zones { get; set; }
    }

}