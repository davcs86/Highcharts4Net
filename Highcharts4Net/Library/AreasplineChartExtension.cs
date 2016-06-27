using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieAreasplineSettings(SeriesAreaspline s);

    public sealed class AreasplineChartSettings : BaseChartSettings<SeriesAreaspline>
    {
		public void AddSeries(SerieAreasplineSettings s) {
			AddSeries (s, new SeriesAreaspline ());
		}
    }

    public sealed class AreasplineChartExtension : BaseChartExtension<AreasplineChartSettings, SeriesAreaspline>
    {
        public AreasplineChartExtension(Action<AreasplineChartSettings> settings): base(settings) { }
    }
}