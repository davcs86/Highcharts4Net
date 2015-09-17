using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieColumnrangeSettings(SeriesColumnrange s);

    public sealed class ColumnrangeChartSettings : BaseChartSettings<SeriesColumnrange>
    {
        public void AddSeries(SerieColumnrangeSettings s)=>AddSeries(s, new SeriesColumnrange());
    }

    public sealed class ColumnrangeChartExtension : BaseChartExtension<ColumnrangeChartSettings>
    {
        public ColumnrangeChartExtension(Action<ColumnrangeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}