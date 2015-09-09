using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class AreasplineChartSettings : BaseChartSettings<SeriesAreaspline> { }

    public sealed class AreasplineChartExtension : BaseChartExtension<AreasplineChartSettings>
    {
        public AreasplineChartExtension(Action<AreasplineChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}