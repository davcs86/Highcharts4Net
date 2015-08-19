using System.Drawing;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class BackgroundObject
    {
        
        public ColorOrGradient BackgroundColor { get; set; }

        public PercentageOrPixel InnerRadius { get; set; }

        public PercentageOrPixel OuterRadius { get; set; }

        public PercentageOrPixel BorderWidth { get; set; }

        public string BorderColor { get; set; }

        public Shapes? Shape { get; set; }
    }
}