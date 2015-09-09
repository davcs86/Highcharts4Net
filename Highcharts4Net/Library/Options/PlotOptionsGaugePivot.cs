using Highcharts4Net.Library.Helpers;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Options for the pivot or the center point of the gauge.
	/// </summary>
	public class PlotOptionsGaugePivot
	{
		/// <summary>
		/// The background color or fill of the pivot.
		/// Default: black
		/// </summary>
		//[JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
		public ColorOrGradient BackgroundColor { get; set; }

		/// <summary>
		/// The border or stroke color of the pivot. In able to change this, the borderWidth must also be set to something other than the default 0.
		/// Default: silver
		/// </summary>
		public string BorderColor { get; set; }

		/// <summary>
		/// The border or stroke width of the pivot.
		/// Default: 0
		/// </summary>
		public Number? BorderWidth { get; set; }

		/// <summary>
		/// The pixel radius of the pivot.
		/// Default: 5
		/// </summary>
		public Number? Radius { get; set; }

	}

}