using System;
using System.Web;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieAreasplinerangeSettings(SeriesAreasplinerange s);

    public sealed class AreasplinerangeChartSettings : BaseChartSettings<SeriesAreasplinerange>
    {
        public void AddSeries(SerieAreasplinerangeSettings s) => AddSeries(s, new SeriesAreasplinerange());
    }

    public sealed class AreasplinerangeChartExtension : BaseChartExtension<AreasplinerangeChartSettings>
    {
        public AreasplinerangeChartExtension(Action<AreasplinerangeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}