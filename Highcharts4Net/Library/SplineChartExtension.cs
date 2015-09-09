using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class SplineChartSettings : BaseChartSettings<SeriesSpline> { }

    public sealed class SplineChartExtension : BaseChartExtension<SplineChartSettings>
    {
        public SplineChartExtension(Action<SplineChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}