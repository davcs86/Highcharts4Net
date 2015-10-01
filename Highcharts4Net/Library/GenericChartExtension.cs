using System;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class GenericChartSettings : BaseChartSettings<ISeries>
    {
        public void AddSeriesArea(SerieAreaSettings s) => AddSeries(s, new SeriesArea());

        public void AddSeriesArearange(SerieArearangeSettings s) => AddSeries(s, new SeriesArearange());

        public void AddSeriesAreaspline(SerieAreasplineSettings s) => AddSeries(s, new SeriesAreaspline());

        public void AddSeriesAreasplinerange(SerieAreasplinerangeSettings s) => AddSeries(s, new SeriesAreasplinerange());

        public void AddSeriesBar(SerieBarSettings s) => AddSeries(s, new SeriesBar());

        public void AddSeriesBoxplot(SerieBoxplotSettings s) => AddSeries(s, new SeriesBoxplot());

        public void AddSeriesBubble(SerieBubbleSettings s) => AddSeries(s, new SeriesBubble());

        public void AddSeriesColumn(SerieColumnSettings s) => AddSeries(s, new SeriesColumn());

        public void AddSeriesColumnrange(SerieColumnrangeSettings s) => AddSeries(s, new SeriesColumnrange());

        public void AddSeriesErrorbar(SerieErrorbarSettings s) => AddSeries(s, new SeriesErrorbar());

        public void AddSeriesFunnel(SerieFunnelSettings s) => AddSeries(s, new SeriesFunnel());

        public void AddSeriesGauge(SerieGaugeSettings s) => AddSeries(s, new SeriesGauge());

        public void AddSeriesHeatmap(SerieHeatmapSettings s) => AddSeries(s, new SeriesHeatmap());

        public void AddSeriesLine(SerieLineSettings s) => AddSeries(s, new SeriesLine());

        public void AddSeriesPie(SeriePieSettings s) => AddSeries(s, new SeriesPie());

        public void AddSeriesPolygon(SeriePolygonSettings s) => AddSeries(s, new SeriesPolygon());

        public void AddSeriesPyramid(SeriePyramidSettings s) => AddSeries(s, new SeriesPyramid());

        public void AddSeriesScatter(SerieScatterSettings s) => AddSeries(s, new SeriesScatter());

        public void AddSeriesSolidgauge(SerieSolidgaugeSettings s) => AddSeries(s, new SeriesSolidgauge());

        public void AddSeriesSpline(SerieSplineSettings s) => AddSeries(s, new SeriesSpline());

        public void AddSeriesTreemap(SerieTreemapSettings s) => AddSeries(s, new SeriesTreemap());

        public void AddSeriesWaterfall(SerieWaterfallSettings s) => AddSeries(s, new SeriesWaterfall());
    }

    public sealed class GenericChartExtension : BaseChartExtension<GenericChartSettings, ISeries>
    {
        public GenericChartExtension(Action<GenericChartSettings> applySettings) : base(applySettings) { }
    }
}