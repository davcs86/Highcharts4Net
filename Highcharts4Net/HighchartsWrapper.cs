using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net
{
    public class HighchartsWrapper
    {
        internal static Highcharts _chart;

        internal void applySettings(ChartSettings settings)
        {
            _chart = new Highcharts(settings.Name)
                .InitChart(settings.Chart)
                .SetLegend(settings.Legend);
        }

        public HtmlString Render()
        {
            return new HtmlString(_chart.ToHtmlString());
        }

    }
}
