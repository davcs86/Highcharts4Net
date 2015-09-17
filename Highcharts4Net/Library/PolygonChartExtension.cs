using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SeriePolygonSettings(SeriesPolygon s);

    public sealed class PolygonChartSettings : BaseChartSettings<SeriesPolygon>
    {
        public void AddSeries(SeriePolygonSettings s)=>AddSeries(s, new SeriesPolygon());
    }

    public sealed class PolygonChartExtension : BaseChartExtension<PolygonChartSettings>
    {
        public PolygonChartExtension(Action<PolygonChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}