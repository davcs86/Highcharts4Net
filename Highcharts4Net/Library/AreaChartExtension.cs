using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieAreaSettings(SeriesArea s);

    public sealed class AreaChartSettings : BaseChartSettings<SeriesArea>
    {
        public void AddSeries(SerieAreaSettings s)=>AddSeries(s, new SeriesArea());
    }

    public sealed class AreaChartExtension : BaseChartExtension<AreaChartSettings, SeriesArea>
    {
        public AreaChartExtension(Action<AreaChartSettings> settings) : base(settings) { }
    }
}