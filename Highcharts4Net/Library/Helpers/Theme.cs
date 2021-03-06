﻿namespace Highcharts4Net.Library.Helpers
{
    public class Theme
    {
        public string Fill { get; set; }
        public string Stroke { get; set; }
        public HighchartsDataPoint? R { get; set; }
        public ThemeStates States { get; set; }
    }

    public class ThemeStates
    {
        public ThemeStatesHover Hover { get; set; }
    }

    public class ThemeStatesHover
    {
        public string Fill { get; set; }

        //[JsonFormatter("{{ {0} }}")]
        public CSSObject Style { get; set; }
    }
}