

using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	public class PlotOptionsBarEvents
	{
		/// <summary>
		/// Fires after the series has finished its initial animation, or in case animation is disabled, immediately as the series is displayed.
		/// </summary>
		
		public FunctionString AfterAnimate { get; set; }

		/// <summary>
		/// Fires when the checkbox next to the series' name in the legend is clicked.. The <code>this</code> keyword refers to the  series object itself. One parameter, <code>event</code>, is passed to the function. The state of the checkbox is found by <code>event.checked</code>. Return <code>false</code> to prevent the default action which is to toggle the select state of the series.
		/// </summary>
		
		public FunctionString CheckboxClick { get; set; }

		/// <summary>
		/// Fires when the series is clicked. The <code>this</code> keyword refers to the  series object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Additionally, <code>event.point</code> holds a pointer to the nearest point on the graph.
		/// </summary>
		
		public FunctionString Click { get; set; }

		/// <summary>
		/// Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling <code>.hide()</code>.
		/// </summary>
		
		public FunctionString Hide { get; set; }

		/// <summary>
		/// Fires when the legend item belonging to the series is clicked.  The <code>this</code> keyword refers to the  series object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action is to toggle the visibility of the series. This can be prevented by returning <code>false</code> or calling <code>event.preventDefault()</code>.
		/// </summary>
		
		public FunctionString LegendItemClick { get; set; }

		/// <summary>
		/// Fires when the mouse leaves the graph. The <code>this</code> keyword refers to the  series object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the  <a class='internal' href='#plotOptions.series'>stickyTracking</a> option is true, <code>mouseOut</code> doesn't happen before the mouse enters another graph or leaves the plot area.
		/// </summary>
		
		public FunctionString MouseOut { get; set; }

		/// <summary>
		/// Fires when the mouse enters the graph. The <code>this</code> keyword refers to the  series object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
		/// </summary>
		
		public FunctionString MouseOver { get; set; }

		/// <summary>
		/// Fires when the series is shown after chart generation time, either by clicking the legend item or by calling <code>.show()</code>.
		/// </summary>
		
		public FunctionString Show { get; set; }

	}

}