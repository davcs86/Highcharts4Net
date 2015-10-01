using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieBarSettings(SeriesBar s);

    public sealed class BarChartSettings : BaseChartSettings<SeriesBar>
    {
        public void AddSeries(SerieBarSettings s)=>AddSeries(s, new SeriesBar());
    }

    public sealed class BarChartExtension : BaseChartExtension<BarChartSettings, SeriesBar>
    {
        public BarChartExtension(Action<BarChartSettings> settings) : base(settings) { }
    }
}