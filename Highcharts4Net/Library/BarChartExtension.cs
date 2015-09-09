using System;
using System.Web;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class BarChartSettings : BaseChartSettings<SeriesBar> { }

    public sealed class BarChartExtension : BaseChartExtension<BarChartSettings>
    {
        public BarChartExtension(Action<BarChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}