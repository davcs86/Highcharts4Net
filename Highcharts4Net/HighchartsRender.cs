using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net
{
    public class HighchartsRender
    {
        private static Highcharts _chart;

        internal void CreateChart(Action<ChartSettings> getSettings, ChartTypes Chart_Type)
        {
            var _chartSettings = new ChartSettings();

            getSettings(_chartSettings);

            _chartSettings.Chart.Type = Chart_Type;

            applySettings(_chartSettings);
        }

        private void applySettings(ChartSettings settings)
        {
            _chart = new Highcharts(settings.Name)
                .InitChart(settings.Chart)
                .SetTitle(settings.Title)
                .SetSubtitle(settings.SubTitle)
                .SetXAxis(settings.XAxis)
                .SetYAxis(settings.YAxis)
                .SetTooltip(settings.Tooltip)
                .SetLegend(settings.Legend);

        }

        public HtmlString Render()
        {
            return new HtmlString(_chart.ToHtmlString());
        }

    }
}
