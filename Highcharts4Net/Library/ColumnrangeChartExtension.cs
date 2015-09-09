using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class ColumnrangeChartSettings : BaseChartSettings<SeriesColumnrange> { }

    public sealed class ColumnrangeChartExtension : BaseChartExtension<ColumnrangeChartSettings>
    {
        public ColumnrangeChartExtension(Action<ColumnrangeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}