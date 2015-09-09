using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class PieChartSettings : BaseChartSettings<SeriesPie> { }

    public sealed class PieChartExtension : BaseChartExtension<PieChartSettings>
    {
        public PieChartExtension(Action<PieChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}