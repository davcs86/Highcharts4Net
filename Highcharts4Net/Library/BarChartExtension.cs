using System;
using System.Web;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieBarSettings(SeriesBar s);

    public sealed class BarChartSettings : BaseChartSettings<SeriesBar>
    {
        public void AddSeries(SerieBarSettings s)=>AddSeries(s, new SeriesBar());
    }

    public sealed class BarChartExtension : BaseChartExtension<BarChartSettings>
    {
        public BarChartExtension(Action<BarChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}