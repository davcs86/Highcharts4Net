using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieSplineSettings(SeriesSpline s);

    public sealed class SplineChartSettings : BaseChartSettings<SeriesSpline>
    {
        public void AddSeries(SerieSplineSettings s)=>AddSeries(s, new SeriesSpline());
    }

    public sealed class SplineChartExtension : BaseChartExtension<SplineChartSettings>
    {
        public SplineChartExtension(Action<SplineChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}