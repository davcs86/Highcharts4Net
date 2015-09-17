using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieBubbleSettings(SeriesBubble s);

    public sealed class BubbleChartSettings : BaseChartSettings<SeriesBubble>
    {
        public void AddSeries(SerieBubbleSettings s)=>AddSeries(s, new SeriesBubble());
    }

    public sealed class BubbleChartExtension : BaseChartExtension<BubbleChartSettings>
    {
        public BubbleChartExtension(Action<BubbleChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}