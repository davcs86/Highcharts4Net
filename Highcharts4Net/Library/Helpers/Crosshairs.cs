using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class Crosshairs
    {
        public Crosshairs(bool showXCrosshairs) { ShowXCrosshairs = showXCrosshairs; }

        public Crosshairs(bool showXCrosshairs, bool sShowYCrosshairs) { ShowBothCrosshairs = new[] { showXCrosshairs, sShowYCrosshairs }; }

        public Crosshairs(CrosshairsFormat xCrosshairsFormat, CrosshairsFormat yCrosshairsFormat) { crosshairsFormat = new[] { xCrosshairsFormat, yCrosshairsFormat }; }

        public bool? ShowXCrosshairs { get; private set; }

        public bool[] ShowBothCrosshairs { get; private set; }

        public CrosshairsFormat[] crosshairsFormat { get; private set; }

        public override string ToString()
        {
            if (crosshairsFormat != null)
            {
                return JSON.ToJSON(crosshairsFormat);
            }
            if (ShowBothCrosshairs != null)
            {
                return JSON.ToJSON(ShowBothCrosshairs);
            }
            return ShowXCrosshairs != null ? JSON.ToJSON(ShowXCrosshairs) : "";
        }
    }

    public class AxisCrosshair
    {
        public AxisCrosshair(bool showCrosshairs) { ShowCrosshairs = showCrosshairs; }

        public AxisCrosshair(CrosshairsFormat crosshairFormat) { CrosshairsFormat = crosshairFormat; }

        public bool? ShowCrosshairs { get; private set; }

        public CrosshairsFormat CrosshairsFormat { get; private set; }

        public override string ToString()
        {
            if (CrosshairsFormat != null)
            {
                return JSON.ToJSON(CrosshairsFormat);
            }
            return ShowCrosshairs != null ? JSON.ToJSON(ShowCrosshairs) : "";
        }
    }

    public class CrosshairsFormat
    {
        public int? Width { get; set; }
        public ColorOrGradient Color { get; set; }
        public DashStyles DashStyle { get; set; }
        public bool? Snap { get; set; }
        public int? ZIndex { get; set; }
    }
}