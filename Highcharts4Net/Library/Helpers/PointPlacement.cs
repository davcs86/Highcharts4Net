using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class PointPlacement
    {
        public PointPlacement(Placement location) { Location = location; }

        public PointPlacement(double position) { Position = position; }


        [Name("pointPlacement")]
        public Placement? Location { get; private set; }
        [Name("pointPlacement")]
        public double? Position { get; private set; }
    }
}
