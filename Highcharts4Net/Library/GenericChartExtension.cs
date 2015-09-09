using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class GenericChartSettings : BaseChartSettings<ISeries> { }

    public sealed class GenericChartExtension : BaseChartExtension<GenericChartSettings>
    {
        public GenericChartExtension(Action<GenericChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}