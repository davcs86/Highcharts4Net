using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieErrorbarSettings(SeriesErrorbar s);
    public sealed class ErrorbarChartSettings : BaseChartSettings<SeriesErrorbar>
    {
        public void AddSeries(SerieErrorbarSettings s)=>AddSeries(s, new SeriesErrorbar());
    }

    public sealed class ErrorbarChartExtension : BaseChartExtension<ErrorbarChartSettings>
    {
        public ErrorbarChartExtension(Action<ErrorbarChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}