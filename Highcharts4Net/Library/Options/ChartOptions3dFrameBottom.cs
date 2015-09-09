using Highcharts4Net.Library.Helpers;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// The bottom of the frame around a 3D chart.
	/// </summary>
	public class ChartOptions3dFrameBottom
	{
		/// <summary>
		/// The color of the panel.
		/// Default: transparent
		/// </summary>
		public ColorOrGradient Color { get; set; }

		/// <summary>
		/// The thickness of the panel.
		/// Default: 1
		/// </summary>
		public Number? Size { get; set; }

	}

}