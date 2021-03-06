

using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Events for each single point
	/// </summary>
	public class PlotOptionsColumnPointEvents
	{
		/// <summary>
		/// <p></p>Fires when a point is clicked. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.<p></p> <p>If the <code>series.allowPointSelect</code> option is true, the default action for the point's click event is to toggle the point's select state. Returning <code>false</code> cancels this action.</p>
		/// </summary>
		
		public FunctionString Click { get; set; }

		/// <summary>
		/// Fires when the mouse leaves the area close to the point. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
		/// </summary>
		
		public FunctionString MouseOut { get; set; }

		/// <summary>
		/// Fires when the mouse enters the area close to the point. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
		/// </summary>
		
		public FunctionString MouseOver { get; set; }

		/// <summary>
		/// Fires when the point is removed using the <code>.remove()</code> method. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation.
		/// </summary>
		
		public FunctionString Remove { get; set; }

		/// <summary>
		/// Fires when the point is selected either programmatically or following a click on the point. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation.
		/// </summary>
		
		public FunctionString Select { get; set; }

		/// <summary>
		/// Fires when the point is unselected either programmatically or following a click on the point. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation.
		/// </summary>
		
		public FunctionString Unselect { get; set; }

		/// <summary>
		/// Fires when the point is updated programmatically through the <code>.update()</code> method. The <code>this</code> keyword refers to the  point object itself. One parameter, <code>event</code>, is passed to the function. The  new point options can be accessed through <code>event.options</code>. Returning <code>false</code> cancels the operation.
		/// </summary>
		
		public FunctionString Update { get; set; }

	}

}