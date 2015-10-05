using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Event listeners for the chart.
	/// </summary>
	public class ChartEvents
	{
		/// <summary>
		/// Fires when a series is added to the chart after load time, using the <code>addSeries</code> method. The <code>this</code> keyword refers to the  chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Through <code>event.options</code> you can access the series options that was passed to the <code>addSeries</code>  method. Returning false prevents the series from being added.
		/// </summary>
		
		public LiteralString AddSeries { get; set; }

        /// <summary>
        /// Fires after a chart is printed through the context menu item or the Chart.print method. Requires the exporting module. The this keyword refers to the <code>Chart</code> object.
        /// </summary>
        
        public LiteralString AfterPrint { get; set; }

        /// <summary>
        /// Fires after a chart is printed through the context menu item or the <pre>Chart.print</pre> method. <strong>Requires the exporting module</strong>. The <pre>this</pre> keyword refers to the <code>Chart</code> object.
        /// </summary>
        
        public LiteralString BeforePrint { get; set; }

        /// <summary>
        /// <p>Fires when clicking on the plot background. The <code>this</code> keyword refers to the  chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.</p> <p>Information on the clicked spot can be found through <code>event.xAxis</code> and  <code>event.yAxis</code>, which are arrays containing the axes of each dimension and each axis' value at the clicked spot. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.</p><pre>click: function(e) { console.log( Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value),  e.yAxis[0].value )}</pre>
        /// </summary>
        public FunctionString Click { get; set; }

		/// <summary>
		/// <p>Fires when a drilldown point is clicked, before the new series is added. Event arguments include <code>point</code> for the originating point, and <code>seriesOptions</code> for the new series.</p><p>This event is also utilized for async drilldown, where the seriesOptions are not added by option, but rather loaded async.</p>
		/// </summary>
		
		public LiteralString Drilldown { get; set; }

		/// <summary>
		/// Fires when drilling up from a drilldown series.
		/// </summary>
		
		public LiteralString Drillup { get; set; }

		/// <summary>
		/// <p>Fires when the chart is finished loading. The <code>this</code> keyword refers to the  chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.</p> <p>From version 2.0.4, there is also a second parameter to <code>Highcharts.Chart</code> where a callback function can be passed to be executed on chart.load.</p>
		/// </summary>
		
		public LiteralString Load { get; set; }

		/// <summary>
		/// Fires when the chart is redrawn, either after a call to chart.redraw() or after an axis, series or point is modified with the <code>redraw</code> option set to true.  The <code>this</code> keyword refers to the  chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
		/// </summary>
		
		public LiteralString Redraw { get; set; }

		/// <summary>
		/// <p>Fires when an area of the chart has been selected. Selection is enabled by setting the chart's zoomType. The <code>this</code> keyword refers to the  chart object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action for the  selection event is to zoom the  chart to the selected area. It can be prevented by calling  <code>event.preventDefault()</code>.</p> <p>Information on the selected area can be found through <code>event.xAxis</code> and  <code>event.yAxis</code>, which are arrays containing the axes of each dimension and each axis' min and max values. The primary axes are <code>event.xAxis[0]</code> and <code>event.yAxis[0]</code>. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.</p> <pre>selection: function(event) { // log the min and max of the primary, datetime x-axis console.log( Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min), Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max) ); // log the min and max of the y axis console.log(event.yAxis[0].min, event.yAxis[0].max);}</pre>
		/// </summary>
		
		public LiteralString Selection { get; set; }

    }

}