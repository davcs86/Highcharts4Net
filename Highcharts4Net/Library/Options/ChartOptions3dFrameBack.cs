using Highcharts4Net.Library.Helpers;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Defines the back panel of the frame around 3D charts.
	/// </summary>
	public class ChartOptions3dFrameBack
	{
		/// <summary>
		/// The color of the panel.
		/// Default: transparent
		/// </summary>
		public ColorOrGradient Color { get; set; }

		/// <summary>
		/// Thickness of the panel.
		/// Default: 1
		/// </summary>
		public Number? Size { get; set; }

	}

}