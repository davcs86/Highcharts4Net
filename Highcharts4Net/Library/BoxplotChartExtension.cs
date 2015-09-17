using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieBoxplotSettings(SeriesBoxplot s);

    public sealed class BoxplotChartSettings : BaseChartSettings<SeriesBoxplot>
    {
        public void AddSeries(SerieBoxplotSettings s)=>AddSeries(s, new SeriesBoxplot());
    }

    public sealed class BoxplotChartExtension : BaseChartExtension<BoxplotChartSettings>
    {
        public BoxplotChartExtension(Action<BoxplotChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}