using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Options for the hovered series
	/// </summary>
	public class PlotOptionsBubbleStatesHover
	{
		/// <summary>
		/// Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend..
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the <code>halo</code> option to <code>false</code>.
		/// </summary>
		public PlotOptionsBubbleStatesHoverHalo Halo { get; set; }

		/// <summary>
		/// The width of the line connecting the data points.
		/// Default: 0
		/// </summary>
		public HighchartsDataPoint? LineWidth { get; set; }

		/// <summary>
		/// The additional line width for the graph of a hovered series.
		/// Default: 1
		/// </summary>
		public HighchartsDataPoint? LineWidthPlus { get; set; }

		public PlotOptionsBubbleStatesHoverMarker Marker { get; set; }

	}

}