using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
    public class PlotOptionsColumnZone
    {
        /// <summary>
        /// Defines the color of the series.
        /// </summary>
        public ColorOrGradient Color { get; set; }

        /// <summary>
        /// A name for the dash style to use for the graph. Applies only to series type having a graph, like <code>line</code>, <code>spline</code>, <code>area</code> and <code>scatter</code> in  case it has a <code>lineWidth</code>. The value for the <code>dashStyle</code> include:    <ul>    <li>Solid</li>    <li>ShortDash</li>    <li>ShortDot</li>    <li>ShortDashDot</li>    <li>ShortDashDotDot</li>    <li>Dot</li>    <li>Dash</li>    <li>LongDash</li>    <li>DashDot</li>    <li>LongDashDot</li>    <li>LongDashDotDot</li>    </ul>
        /// Default: Solid
        /// </summary>
        public DashStyles? DashStyle { get; set; }

        /// <summary>
        /// Defines the fill color for the series (in area type series).
        /// </summary>
        public ColorOrGradient FillColor { get; set; }

        /// <summary>
        /// The value up to where the zone extends, if undefined the zones stretches to the last value in the series. 
        /// Default: undefined.
        /// </summary>
        public Number? Value { get; set; }
    }
}
