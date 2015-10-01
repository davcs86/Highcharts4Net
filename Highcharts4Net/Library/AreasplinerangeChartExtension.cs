using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieAreasplinerangeSettings(SeriesAreasplinerange s);

    public sealed class AreasplinerangeChartSettings : BaseChartSettings<SeriesAreasplinerange>
    {
        public void AddSeries(SerieAreasplinerangeSettings s) => AddSeries(s, new SeriesAreasplinerange());
    }

    public sealed class AreasplinerangeChartExtension : BaseChartExtension<AreasplinerangeChartSettings, SeriesAreasplinerange>
    {
        public AreasplinerangeChartExtension(Action<AreasplinerangeChartSettings> settings) : base(settings) { }
    }
}