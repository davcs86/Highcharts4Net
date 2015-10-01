using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieBoxplotSettings(SeriesBoxplot s);

    public sealed class BoxplotChartSettings : BaseChartSettings<SeriesBoxplot>
    {
        public void AddSeries(SerieBoxplotSettings s)=>AddSeries(s, new SeriesBoxplot());
    }

    public sealed class BoxplotChartExtension : BaseChartExtension<BoxplotChartSettings, SeriesBoxplot>
    {
        public BoxplotChartExtension(Action<BoxplotChartSettings> settings) : base(settings) { }
    }
}