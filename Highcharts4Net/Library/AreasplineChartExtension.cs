using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieAreasplineSettings(SeriesAreaspline s);

    public sealed class AreasplineChartSettings : BaseChartSettings<SeriesAreaspline>
    {
        public void AddSeries(SerieAreasplineSettings s) => AddSeries(s, new SeriesAreaspline());
    }

    public sealed class AreasplineChartExtension : BaseChartExtension<AreasplineChartSettings>
    {
        public AreasplineChartExtension(Action<AreasplineChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}