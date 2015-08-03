using System;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    public class LineChart : HighchartsWrapper
    {

        private void CreateChart(Action<ChartSettings> getSettings, ChartTypes Chart_Type)
        {
            var _chartSettings = new ChartSettings();

            getSettings(_chartSettings);

            // override chart type
            _chartSettings.Chart.Type = Chart_Type;

            applySettings(_chartSettings);
        }

        public LineChart(Action<ChartSettings> getSettings)
        {

            CreateChart(getSettings, ChartTypes.Line);

        }
    }
}
