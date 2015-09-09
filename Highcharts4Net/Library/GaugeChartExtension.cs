using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class GaugeChartSettings : BaseChartSettings<SeriesGauge> { }

    public sealed class GaugeChartExtension : BaseChartExtension<GaugeChartSettings>
    {
        public GaugeChartExtension(Action<GaugeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}