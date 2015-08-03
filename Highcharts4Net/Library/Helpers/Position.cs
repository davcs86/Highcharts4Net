using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    /// <summary>
    /// Position configuration
    /// </summary>
    public class Position
    {

        /// <summary>
        /// Get and set the horizontal alignment
        /// </summary>
        public HorizontalAligns? Align { get; set; }

        /// <summary>
        /// Get and set the vertical alignment
        /// </summary>
        public VerticalAligns? VerticalAlign { get; set; }

        /// <summary>
        /// Get and set the X position
        /// </summary>
        public int? X { get; set; }

        /// <summary>
        /// Get and set the Y position
        /// </summary>
        public int? Y { get; set; }
    }
}