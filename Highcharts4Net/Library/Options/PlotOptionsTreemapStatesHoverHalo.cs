﻿using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
    public class PlotOptionsTreemapStatesHoverHalo
    {
        /// <summary>
		/// A collection of SVG attributes to override the appearance of the halo, for example <code>fill</code>, <code>stroke</code> and <code>stroke-width</code>.
		/// </summary>
        public PlotOptionsTreemapStatesHoverHaloAttributes Attributes { get; set; }

        /// <summary>
        /// Opacity for the halo unless a specific fill is overridden using the <code>attributes</code> setting. Note that Highcharts is only able to apply opacity to colors of hex or rgb(a) formats.
        /// Default: 0.25
        /// </summary>
        public NumberOrDateTime? Opacity { get; set; }

        /// <summary>
        /// The pixel size of the halo. For point markers this is the radius of the halo. For pie slices it is the width of the halo outside the slice. For bubbles it defaults to 5 and is the width of the halo outside the bubble.
        /// Default: 10
        /// </summary>
        public NumberOrDateTime? Size { get; set; }
    }
}