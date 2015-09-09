using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
    public class AxisBreaks
    {
        /// <summary>
        /// A number indicating how much space should be left between the start and the end of the break. The break size is given in axis units, so for instance on a <pre>datetime</pre> axis, a break size of 3600000 would indicate the equivalent of an hour.
        /// </summary>
        public Number? BreakSize { get; set; }

        /// <summary>
        /// The point where the break starts.
        /// </summary>
        public Number? From { get; set; }

        /// <summary>
        /// Defines an interval after which the break appears again. By default the breaks do not repeat.
        /// </summary>
        public Number? Repeat { get; set; }

        /// <summary>
        /// The point where the break ends.
        /// </summary>
        public Number? To { get; set; }

    }
}
