using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	public class PlotOptionsAreaMarkerStatesHover
	{
		/// <summary>
		/// Enable or disable the point marker.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// The fill color of the marker in hover state.
		/// </summary>
		public ColorOrGradient FillColor { get; set; }

		/// <summary>
		/// The color of the point marker's outline. When <code>null</code>, the series' or point's color is used.
		/// Default: #FFFFFF
		/// </summary>
		public string LineColor { get; set; }

		/// <summary>
		/// The width of the point marker's outline.
		/// Default: 0
		/// </summary>
		public HighchartsDataPoint? LineWidth { get; set; }

		/// <summary>
		/// The additional line width for a hovered point.
		/// Default: 1
		/// </summary>
		public HighchartsDataPoint? LineWidthPlus { get; set; }

		/// <summary>
		/// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the <a href='#plotOptions.series.marker.states.hover.radiusPlus'>radiusPlus</a> option.
		/// </summary>
		public HighchartsDataPoint? Radius { get; set; }

		/// <summary>
		/// The number of pixels to increase the radius of the hovered point.
		/// Default: 2
		/// </summary>
		public HighchartsDataPoint? RadiusPlus { get; set; }

	}

}