using System.Drawing;
using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class Crosshairs
    {
        public Crosshairs(bool showXCrosshairs) { ShowXCrosshairs = showXCrosshairs; }

        public Crosshairs(bool showXCrosshairs, bool sShowYCrosshairs) { ShowBothCrosshairs = new[] { showXCrosshairs, sShowYCrosshairs }; }

        public Crosshairs(CrosshairsFormat xCrosshairsFormat, CrosshairsFormat yCrosshairsFormat) { CrosshairsFormat = new[] { xCrosshairsFormat, yCrosshairsFormat }; }

        public bool? ShowXCrosshairs { get; }

        public bool[] ShowBothCrosshairs { get; }

        public CrosshairsFormat[] CrosshairsFormat { get; }

        public override string ToString()
        {
            if (CrosshairsFormat!=null)
            {
                return JSON.ToJSON(CrosshairsFormat);
            }
            if (ShowBothCrosshairs != null)
            {
                return JSON.ToJSON(ShowBothCrosshairs);
            }
            return ShowXCrosshairs != null ? JSON.ToJSON(ShowXCrosshairs) : "";
        }
    }

    public class CrosshairsFormat
    {
        public int? Width { get; set; }
        public ColorOrGradient Color { get; set; }
        public DashStyles DashStyle { get; set; }
        public int? ZIndex { get; set; }
    }
}