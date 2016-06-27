using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieFunnelSettings(SeriesFunnel s);
    public sealed class FunnelChartSettings : BaseChartSettings<SeriesFunnel>
    {
		public void AddSeries(SerieFunnelSettings s){
			AddSeries (s, new SeriesFunnel ());
		}
    }

    public sealed class FunnelChartExtension : BaseChartExtension<FunnelChartSettings, SeriesFunnel>
    {
        public FunnelChartExtension(Action<FunnelChartSettings> applySettings) : base(applySettings) { }
    }
}