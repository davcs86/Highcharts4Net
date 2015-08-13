//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Options
{
    public class PlotOptionsBoxplotStatesHoverHaloAttributes
    {

        /// <summary>
        /// The fill attribute is a presentation attribute that define the color of the interior of the given graphical element.
        /// </summary>
        //[JsonFormatter("{0}")]
        public string Fill { get; set; }

        /// <summary>
        /// The stroke-width attribute specifies the width of the outline on the current object. Its default value is 1. If a <pre>percentage</pre> is used, the value represents a percentage of the current viewport. If a value of 0 is used the outline will never be drawn.
        /// </summary>
        //[Name("stroke-width")]
        //[JsonFormatter("{0}")]
        public string StrokeWidth { get; set; }

        /// <summary>
        /// The stroke attribute defines the color of the outline on a given graphical element.
        /// </summary>
        //[JsonFormatter("{0}")]
        public string Stroke { get; set; }

    }
}
