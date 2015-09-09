using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class ScatterChartSettings : BaseChartSettings<SeriesScatter> { }

    public sealed class ScatterChartExtension : BaseChartExtension<ScatterChartSettings>
    {
        public ScatterChartExtension(Action<ScatterChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}