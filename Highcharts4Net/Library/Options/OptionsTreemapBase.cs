using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Options
{
    public class OptionsTreemapBase
    {
        /// <summary>
		/// When enabled the user can click on a point which is a parent and zoom in on its children.
		/// Default: false
		/// </summary>
		public bool? AllowDrillToNode { get; set; }

        /// <summary>
		/// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
		/// Default: false
		/// </summary>
		public bool? AllowPointSelect { get; set; }

        /// <summary>
		/// Enabling this option will make the treemap alternate the drawing direction between vertical and horizontal. The next levels starting direction will always be the opposite of the previous.
		/// Default: false
		/// </summary>
		public bool? AlternateStartingDirection { get; set; }

        /// <summary>
        /// <p>Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see <a href='#chart.animation'>chart.animation</a> and the animation parameter under the API methods.The following properties are supported:</p><dl>  <dt>duration</dt>  <dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>When using jQuery as the general framework, the easing can be set to <code>linear</code> or<code>swing</code>. More easing functions are available with the use of jQuery plug-ins, most notablythe jQuery UI suite. See <a href='http://api.jquery.com/animate/'>the jQuery docs</a>. When using MooTools as the general framework, use the property name <code>transition</code> instead of <code>easing</code>.</dd></dl><p>Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.</p>
        /// Default: true
        /// </summary>
        //[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
        public Animation Animation { get; set; }

        /// <summary>
        /// The color of the border of each waterfall column.
        /// Default: #333333
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// The width of the border surrounding each column or bar.
        /// Default: 1
        /// </summary>
        public Number? BorderWidth { get; set; }

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

        public PlotOptionsTreemapDataLabels DataLabels { get; set; }
        
        /// <summary>
        /// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
        /// Default: true
        /// </summary>
        public bool? EnableMouseTracking { get; set; }

        public PlotOptionsTreemapEvents Events { get; set; }

        /// <summary>
        /// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
        /// Default: false
        /// </summary>
        public bool? GetExtremesFromAll { get; set; }

        /// <summary>
        /// This option decides if the user can interact with the parent nodes or just the leaf nodes. 
        /// Default: When this option is undefined, it will be true by default. However when allowDrillToNode is true, then it will be false by default.
        /// </summary>
        public bool? InteractByLeaf { get; set; }

        /// <summary>
        /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
        /// </summary>
        public string[] Keys { get; set; }

        /// <summary>
        /// This option decides which algorithm is used for setting position and dimensions of the points. Can be one of sliceAndDice, stripes, squarified or strip. 
        /// Default: SliceAndDice.
        /// </summary>
        public LayoutAlgorithms? LayoutAlgorithm { get; set; }

        /// <summary>
        /// Defines which direction the layout algorithm will start drawing. Possible values are "vertical" and "horizontal". 
        /// Defaults: vertical.
        /// </summary>
        public LayoutStartingDirections? LayoutStartingDirection { get; set; }

        /// <summary>
        /// Set options on specific levels. Takes precedence over series options, but not point options.
        /// </summary>
        public PlotOptionsTreemapLevels[] Levels { get; set; }

        /// <summary>
        /// The <a href='#series.id'>id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
        /// </summary>
        public string LinkedTo { get; set; }

        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PlotOptionsTreemapPoint Point { get; set; }
        
        /// <summary>
        /// Whether to select the series initially. If <code>showCheckbox</code> is true, the checkbox next to the series name will be checked for a selected series.
        /// Default: false
        /// </summary>
        public bool? Selected { get; set; }

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
        public PlotOptionsTreemapStates States { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
        /// Default: true
        /// </summary>
        public bool? StickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href='#tooltip'>tooltip</a>, but only the following properties can be defined on a series level.
        /// </summary>
        public PlotOptionsTreemapTooltip Tooltip { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to <code>0</code> disable.
        /// Default: 1000
        /// </summary>
        public Number? TurboThreshold { get; set; }

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
        public PlotOptionsTreemapZone[] Zones { get; set; }
    }
}
