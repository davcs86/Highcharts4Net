using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieColumnSettings(SeriesColumn s);

    public sealed class ColumnChartSettings : BaseChartSettings<SeriesColumn>
    {
        public void AddSeries(SerieColumnSettings s)=> AddSeries(s, new SeriesColumn());
    }

    public sealed class ColumnChartExtension : BaseChartExtension<ColumnChartSettings>
    {
        public ColumnChartExtension(Action<ColumnChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}