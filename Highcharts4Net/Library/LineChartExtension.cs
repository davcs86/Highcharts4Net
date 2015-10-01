using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieLineSettings(SeriesLine s);
    public sealed class LineChartSettings : BaseChartSettings<SeriesLine>
    {
        public void AddSeries(SerieLineSettings s)=>AddSeries(s, new SeriesLine());
    }

    public sealed class LineChartExtension : BaseChartExtension<LineChartSettings, SeriesLine>
    {
        public LineChartExtension(Action<LineChartSettings> applySettings) : base(applySettings) { }
    }

}