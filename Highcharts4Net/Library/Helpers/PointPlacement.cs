using Highcharts4Net.Library.Enums;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Helpers
{
    public class PointPlacement
    {
        public PointPlacement(Placement location) { Location = location; }

        public PointPlacement(double position) { Position = position; }


        //[Name("pointPlacement")]
        public Placement? Location { get; private set; }
        //[Name("pointPlacement")]
        public double? Position { get; private set; }
    }
}
