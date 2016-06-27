using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieWaterfallSettings(SeriesWaterfall s);

    public sealed class WaterfallChartSettings : BaseChartSettings<SeriesWaterfall>
    {
		public void AddSeries(SerieWaterfallSettings s) {
			AddSeries (s, new SeriesWaterfall ());
		}
    }

    public sealed class WaterfallChartExtension : BaseChartExtension<WaterfallChartSettings, SeriesWaterfall>
    {
        public WaterfallChartExtension(Action<WaterfallChartSettings> applySettings) : base(applySettings) { }
    }
}