using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class HeatmapChartSettings : BaseChartSettings<SeriesHeatmap> { }

    public sealed class HeatmapChartExtension : BaseChartExtension<HeatmapChartSettings>
    {
        public HeatmapChartExtension(Action<HeatmapChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}