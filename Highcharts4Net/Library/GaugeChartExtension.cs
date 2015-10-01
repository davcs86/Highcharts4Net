using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieGaugeSettings(SeriesGauge s);

    public sealed class GaugeChartSettings : BaseChartSettings<SeriesGauge>
    {
        public void AddSeries(SerieGaugeSettings s)=>AddSeries(s, new SeriesGauge());
    }

    public sealed class GaugeChartExtension : BaseChartExtension<GaugeChartSettings, SeriesGauge>
    {
        public GaugeChartExtension(Action<GaugeChartSettings> applySettings) : base(applySettings) { }
    }
}