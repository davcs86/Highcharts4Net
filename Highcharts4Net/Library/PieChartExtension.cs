using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SeriePieSettings(SeriesPie s);

    public sealed class PieChartSettings : BaseChartSettings<SeriesPie>
    {
        public void AddSeries(SeriePieSettings s)=>AddSeries(s, new SeriesPie());
    }

    public sealed class PieChartExtension : BaseChartExtension<PieChartSettings, SeriesPie>
    {
        public PieChartExtension(Action<PieChartSettings> applySettings) : base(applySettings) { }
    }
}