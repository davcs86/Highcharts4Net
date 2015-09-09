using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class ColumnChartSettings : BaseChartSettings<SeriesColumn> { }

    public sealed class ColumnChartExtension : BaseChartExtension<ColumnChartSettings>
    {
        public ColumnChartExtension(Action<ColumnChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}