using System;
using System.Web;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class AreasplinerangeChartSettings : BaseChartSettings<SeriesAreasplinerange> { }

    public sealed class AreasplinerangeChartExtension : BaseChartExtension<AreasplinerangeChartSettings>
    {
        public AreasplinerangeChartExtension(Action<AreasplinerangeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}