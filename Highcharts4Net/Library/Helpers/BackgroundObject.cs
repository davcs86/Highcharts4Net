using System.Drawing;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class BackgroundObject
    {
        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public BackColorOrGradient BackgroundColor { get; set; }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public PercentageOrPixel InnerRadius { get; set; }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public PercentageOrPixel OuterRadius { get; set; }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public PercentageOrPixel BorderWidth { get; set; }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public Color? BorderColor { get; set; }

        [JsonFormatter(addPropertyName: true, useCurlyBracketsForObject: false)]
        public Shapes? Shape { get; set; }
    }
}