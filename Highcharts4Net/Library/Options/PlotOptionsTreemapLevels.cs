using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
    public class PlotOptionsTreemapLevels
    {

        /// <summary>
        /// The color of the border of each waterfall column.
        /// Default: #333333
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Set the dash style of the border of all the point which lies on the level.
        /// </summary>
        public DashStyles? BorderDashStyles { get; set; }

        /// <summary>
        /// The width of the border surrounding each column or bar.
        /// Default: 1
        /// </summary>
        public Number? BorderWidth { get; set; }

        /// <summary>
        /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  <code>options.colors</code> array.
        /// </summary>
        public ColorOrGradient Color { get; set; }

        public PlotOptionsTreemapDataLabels DataLabels { get; set; }

        /// <summary>
        /// This option decides which algorithm is used for setting position and dimensions of the points. Can be one of sliceAndDice, stripes, squarified or strip. 
        /// Default: SliceAndDice.
        /// </summary>
        public LayoutAlgorithms? LayoutAlgorithm { get; set; }

        /// <summary>
        /// Defines which direction the layout algorithm will start drawing. Possible values are "vertical" and "horizontal". 
        /// Defaults: vertical.
        /// </summary>
        public LayoutStartingDirections? LayoutStartingDirection { get; set; }

        /// <summary>
        /// Decides which level takes effect from the options set in the levels object.
        /// </summary>
        public int Level { get; set; }

    }
}