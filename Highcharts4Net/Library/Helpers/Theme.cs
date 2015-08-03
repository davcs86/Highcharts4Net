using System.Drawing;
using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Helpers
{
    public class Theme
    {
        public Color? Fill { get; set; }
        public Color? Stroke { get; set; }
        public Number? R { get; set; }
        public ThemeStates States { get; set; }
    }

    public class ThemeStates
    {
        public ThemeStatesHover Hover { get; set; }
    }

    public class ThemeStatesHover
    {
        public Color? Fill { get; set; }

        [JsonFormatter("{{ {0} }}")]
        public string Style { get; set; }
    }
}