using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieErrorbarSettings(SeriesErrorbar s);
    public sealed class ErrorbarChartSettings : BaseChartSettings<SeriesErrorbar>
    {
        public void AddSeries(SerieErrorbarSettings s)=>AddSeries(s, new SeriesErrorbar());
    }

    public sealed class ErrorbarChartExtension : BaseChartExtension<ErrorbarChartSettings, SeriesErrorbar>
    {
        public ErrorbarChartExtension(Action<ErrorbarChartSettings> applySettings) : base(applySettings) { }
    }
}