﻿using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
    public class OptionsHeatmapBase
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
        /// The color of the border surrounding each column or bar.
        /// Default: #FFFFFF
        /// </summary>
        public ColorOrGradient BorderColor { get; set; }

        /// <summary>
        /// The corner radius of the border surrounding each column or bar.
        /// Default: 0
        /// </summary>
        public HighchartsDataPoint? BorderRadius { get; set; }

        /// <summary>
        /// The width of the border surrounding each column or bar.
        /// Default: 1
        /// </summary>
        public HighchartsDataPoint? BorderWidth { get; set; }

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
        /// The column size - how many X axis units each column in the heatmap.
        /// Default: 1
        /// </summary>
        public HighchartsDataPoint? Colsize { get; set; }

        /// <summary>
        /// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
        /// Default: 50
        /// </summary>
        public HighchartsDataPoint? CropThreshold { get; set; }

        /// <summary>
        /// You can set the cursor to 'pointer' if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
        /// </summary>
        public Cursors? Cursor { get; set; }

        /// <summary>
        /// Data labels for the gauge. For gauges, the data labels are enabled by default and shown in a bordered box below the point.
        /// </summary>
        public PlotOptionsHeatmapDataLabels DataLabels { get; set; }

        /// <summary>
        /// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
        /// Default: true
        /// </summary>
        public bool? EnableMouseTracking { get; set; }

        public PlotOptionsHeatmapEvents Events { get; set; }

        /// <summary>
        /// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
        /// Default: false
        /// </summary>
        public bool? GetExtremesFromAll { get; set; }

        /// <summary>
        /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
        /// </summary>
        public string[] Keys { get; set; }

        /// <summary>
        /// The <a href='#series.id'>id</a> of another series to link to. Additionally, the value can be ':previous' to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
        /// </summary>
        public string LinkedTo { get; set; }
        
        /// <summary>
        /// Properties for each single point
        /// </summary>
        public PlotOptionsHeatmapPoint Point { get; set; }

        /// <summary>
        /// The row size - how many Y axis units each heatmap row should span.
        /// Default: 1
        /// </summary>
        public HighchartsDataPoint? Rowsize { get; set; }

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
        /// Whether to display this particular series or series type in the legend. Defaults to false for gauge series.
        /// </summary>
        public bool? ShowInLegend { get; set; }

        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public PlotOptionsHeatmapStates States { get; set; }

        /// <summary>
        /// Sticky tracking of mouse events. When true, the <code>mouseOut</code> event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the <code>mouseOut</code> event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When <code>stickyTracking</code> is false and <code>tooltip.shared</code> is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
        /// Default: true
        /// </summary>
        public bool? StickyTracking { get; set; }

        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from <a href='#tooltip'>tooltip</a>, but only the following properties can be defined on a series level.
        /// </summary>
        public PlotOptionsHeatmapTooltip Tooltip { get; set; }

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
        /// Defines the Axis on which the zones are applied.
        /// Default: y.
        /// </summary>
        public string ZoneAxis { get; set; }

        /// <summary>
        /// An array defining zones within a series.
        /// </summary>
        public PlotOptionsHeatmapZone[] Zones { get; set; }
    }
}
