

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Event handlers for the axis.
	/// </summary>
	public class XAxisEvents
	{
        /// <summary>
        /// An event fired after the breaks have rendered.
        /// </summary>
        
        public string AfterBreaks { get; set; }

		/// <summary>
		/// As opposed to the <code>setExtremes</code> event, this event fires after the final min and max values are computed and corrected for <code>minRange</code>.
		/// </summary>
		
		public string AfterSetExtremes { get; set; }

        /// <summary>
        /// An event fired when a break from this axis occurs on a point.
        /// </summary>
        
        public string PointBreak { get; set; }

		/// <summary>
		/// <p>Fires when the minimum and maximum is set for the axis, either by calling the <code>.setExtremes()</code> method or by selecting an area in the chart. The <code>this</code> keyword refers to the axis object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.</p><p>The new user set minimum and maximum values can be found by <code>event.min</code> and <code>event.max</code>. When an axis is zoomed all the way out from the 'Reset zoom' button, <code>event.min</code> and <code>event.max</code> are null, and the new extremes are set based on <code>this.dataMin</code> and <code>this.dataMax</code>.</p>
		/// </summary>
		
		public string SetExtremes { get; set; }

	}

}