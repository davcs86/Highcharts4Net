using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieBubbleSettings(SeriesBubble s);

    public sealed class BubbleChartSettings : BaseChartSettings<SeriesBubble>
    {
		public void AddSeries(SerieBubbleSettings s) {
			AddSeries (s, new SeriesBubble());
		}
    }

    public sealed class BubbleChartExtension : BaseChartExtension<BubbleChartSettings, SeriesBubble>
    {
        public BubbleChartExtension(Action<BubbleChartSettings> applySettings) : base(applySettings) { }
    }
}