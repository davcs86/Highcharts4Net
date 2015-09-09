using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class ErrorbarChartSettings : BaseChartSettings<SeriesErrorbar> { }

    public sealed class ErrorbarChartExtension : BaseChartExtension<ErrorbarChartSettings>
    {
        public ErrorbarChartExtension(Action<ErrorbarChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}