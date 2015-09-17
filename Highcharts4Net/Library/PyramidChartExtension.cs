using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SeriePyramidSettings(SeriesPyramid s);

    public sealed class PyramidChartSettings : BaseChartSettings<SeriesPyramid>
    {
        public void AddSeries(SeriePyramidSettings s)=>AddSeries(s, new SeriesPyramid());
    }

    public sealed class PyramidChartExtension : BaseChartExtension<PyramidChartSettings>
    {
        public PyramidChartExtension(Action<PyramidChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}