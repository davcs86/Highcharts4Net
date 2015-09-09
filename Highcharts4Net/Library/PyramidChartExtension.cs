using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class PyramidChartSettings : BaseChartSettings<SeriesPyramid> { }

    public sealed class PyramidChartExtension : BaseChartExtension<PyramidChartSettings>
    {
        public PyramidChartExtension(Action<PyramidChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}