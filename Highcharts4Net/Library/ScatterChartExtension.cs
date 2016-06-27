using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieScatterSettings(SeriesScatter s);

    public sealed class ScatterChartSettings : BaseChartSettings<SeriesScatter>
    {
		public void AddSeries(SerieScatterSettings s){
			AddSeries (s, new SeriesScatter ());
		}
    }

    public sealed class ScatterChartExtension : BaseChartExtension<ScatterChartSettings, SeriesScatter>
    {
        public ScatterChartExtension(Action<ScatterChartSettings> applySettings) : base(applySettings) { }
    }
}