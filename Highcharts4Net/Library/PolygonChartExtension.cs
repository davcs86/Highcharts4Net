using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SeriePolygonSettings(SeriesPolygon s);

    public sealed class PolygonChartSettings : BaseChartSettings<SeriesPolygon>
    {
        public void AddSeries(SeriePolygonSettings s)=>AddSeries(s, new SeriesPolygon());
    }

    public sealed class PolygonChartExtension : BaseChartExtension<PolygonChartSettings, SeriesPolygon>
    {
        public PolygonChartExtension(Action<PolygonChartSettings> applySettings) : base(applySettings) { }
    }
}