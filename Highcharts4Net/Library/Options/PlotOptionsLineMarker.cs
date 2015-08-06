using System;
using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	public class PlotOptionsLineMarker
	{
		/// <summary>
		/// Enable or disable the point marker.
		/// Default: true
		/// </summary>
		public bool? Enabled { get; set; }

		/// <summary>
		/// The fill color of the point marker. When <code>null</code>, the series' or point's color is used.
		/// </summary>
		public Color? FillColor { get; set; }

        /// <summary>
        /// Image markers only. Set the image height explicitly. When using this option, a width must also be set. 
        /// Default: null
        /// </summary>
        public Number? Height { get; set; }

        /// <summary>
        /// The color of the point marker's outline. When <code>null</code>, the series' or point's color is used.
        /// Default: #FFFFFF
        /// </summary>
        public Color? LineColor { get; set; }

		/// <summary>
		/// The width of the point marker's outline.
		/// Default: 0
		/// </summary>
		public Number? LineWidth { get; set; }

		/// <summary>
		/// The radius of the point marker.
		/// Default: 4
		/// </summary>
		public Number? Radius { get; set; }

		public PlotOptionsLineMarkerStates States { get; set; }

		/// <summary>
		/// <p>A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are 'circle', 'square', 'diamond', 'triangle' and 'triangle-down'.</p><p>Additionally, the URL to a graphic can be given on this form:  'url(graphic.png)'. Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.</p><p>Custom callbacks for symbol path generation can also be added to <code>Highcharts.SVGRenderer.prototype.symbols</code>. The callback is then used by its method name, as shown in the demo.</p>
		/// </summary>
		public string Symbol { get; set; }

        /// <summary>
        /// Image markers only. Set the image width explicitly. When using this option, a height must also be set. 
        /// Default: null
        /// </summary>
        public Number? Width { get; set; }
    }

}