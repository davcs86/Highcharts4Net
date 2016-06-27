using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieHeatmapSettings(SeriesHeatmap s);
    public sealed class HeatmapChartSettings : BaseChartSettings<SeriesHeatmap>
    {
		public void AddSeries(SerieHeatmapSettings s){
			AddSeries (s, new SeriesHeatmap ());
		}
    }

    public sealed class HeatmapChartExtension : BaseChartExtension<HeatmapChartSettings, SeriesHeatmap>
    {
        public HeatmapChartExtension(Action<HeatmapChartSettings> applySettings) : base(applySettings) { }
    }
}