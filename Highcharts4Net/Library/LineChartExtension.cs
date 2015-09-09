using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class LineChartSettings : BaseChartSettings<SeriesLine> { }

    public sealed class LineChartExtension : BaseChartExtension<LineChartSettings>
    {
        public LineChartExtension(Action<LineChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}