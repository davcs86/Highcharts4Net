using System.Drawing;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class Crosshairs
    {
        public Crosshairs(bool showXCrosshairs) { ShowXCrosshairs = showXCrosshairs; }

        public Crosshairs(bool showXCrosshairs, bool sShowYCrosshairs) { ShowBothCrosshairs = new[] { showXCrosshairs, sShowYCrosshairs }; }

        public Crosshairs(CrosshairsForamt xCrosshairsForamt, CrosshairsForamt yCrosshairsForamt) { CrosshairsForamt = new[] { xCrosshairsForamt, yCrosshairsForamt }; }

        public bool? ShowXCrosshairs { get; private set; }

        public bool[] ShowBothCrosshairs { get; private set; }

        public CrosshairsForamt[] CrosshairsForamt { get; private set; }
    }

    public class CrosshairsForamt
    {
        public int? Width { get; set; }
        public Color? Color { get; set; }
        public DashStyles DashStyle { get; set; }
        public int? ZIndex { get; set; }
    }
}