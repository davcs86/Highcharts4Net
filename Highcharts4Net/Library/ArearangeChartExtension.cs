using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieArearangeSettings(SeriesArearange s);

    public sealed class ArearangeChartSettings : BaseChartSettings<SeriesArearange>
    {
        public void AddSeries(SerieArearangeSettings s) => AddSeries(s, new SeriesArearange());
    }

    public sealed class ArearangeChartExtension : BaseChartExtension<ArearangeChartSettings>
    {
        public ArearangeChartExtension(Action<ArearangeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}