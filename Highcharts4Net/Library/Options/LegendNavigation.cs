using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Options for the paging or navigation appearing when the legend is overflown. When <a href='#legend.useHTML'>legend.useHTML</a> is enabled, navigation is disabled. 
	/// </summary>
	public class LegendNavigation
	{
		/// <summary>
		/// The color for the active up or down arrow in the legend page navigation.
		/// Default: #3E576F
		/// </summary>
		public string ActiveColor { get; set; }

		/// <summary>
		/// How to animate the pages when navigating up or down. A value of <code>true</code> applies the default navigation given in  the chart.animation option. Additional options can be given as an object containing values for easing and duration.  .
		/// Default: true
		/// </summary>
		//[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Animation Animation { get; set; }

		/// <summary>
		/// The pixel size of the up and down arrows in the legend paging navigation.  .
		/// Default: 12
		/// </summary>
		public Number? ArrowSize { get; set; }

		/// <summary>
		/// The color of the inactive up or down arrow in the legend page navigation.  .
		/// Default: #CCC
		/// </summary>
		public string InactiveColor { get; set; }

		/// <summary>
		/// Text styles for the legend page navigation.
		/// </summary>
		//[JsonFormatter("{{ {0} }}")]
		public string Style { get; set; }

	}

}