using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
    public class PlotOptionsPolygonMarkerStatesSelect
    {
        /// <summary>
		/// Enable or disable visible feedback for selection.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

        /// <summary>
        /// The fill color of the point marker.
        /// </summary>
        public ColorOrGradient FillColor { get; set; }

        /// <summary>
        /// The color of the point marker's outline. When <code>null</code>, the series' or point's color is used.
        /// Default: #000000
        /// </summary>
        public string LineColor { get; set; }

        /// <summary>
        /// The width of the point marker's outline.
        /// Default: 0
        /// </summary>
        public Number? LineWidth { get; set; }

        /// <summary>
        /// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2.
        /// </summary>
        public Number? Radius { get; set; }

    }
}