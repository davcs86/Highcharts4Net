using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieSolidgaugeSettings(SeriesSolidgauge s);

    public sealed class SolidgaugeChartSettings : BaseChartSettings<SeriesSolidgauge>
    {
        public void AddSeries(SerieSolidgaugeSettings s)=>AddSeries(s, new SeriesSolidgauge());
    }

    public sealed class SolidgaugeChartExtension : BaseChartExtension<SolidgaugeChartSettings>
    {
        public SolidgaugeChartExtension(Action<SolidgaugeChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}