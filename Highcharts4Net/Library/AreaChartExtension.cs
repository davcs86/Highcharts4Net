using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class AreaChartSettings : BaseChartSettings<SeriesArea> { }

    public sealed class AreaChartExtension : BaseChartExtension<AreaChartSettings>
    {
        public AreaChartExtension(Action<AreaChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}