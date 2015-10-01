using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieArearangeSettings(SeriesArearange s);

    public sealed class ArearangeChartSettings : BaseChartSettings<SeriesArearange>
    {
        public void AddSeries(SerieArearangeSettings s) => AddSeries(s, new SeriesArearange());
    }

    public sealed class ArearangeChartExtension : BaseChartExtension<ArearangeChartSettings, SeriesArearange>
    {
        public ArearangeChartExtension(Action<ArearangeChartSettings> settings) : base(settings) { }
    }
}