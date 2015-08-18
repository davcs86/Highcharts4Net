using System;
using System.Collections.Generic;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    public class ChartSettings<T>
    {
        [System.Xml.Serialization.XmlIgnore]
        public string name { get; set; }

        public Chart Chart { get; }
        public Credits Credits { get; set; }
        public Legend Legend { set; get; }
        public Title Title { set; get; }
        public Subtitle Subtitle { set; get; }

        public XAxis XAxis { get; set; }
        public YAxis YAxis { get; set; }

        public Tooltip Tooltip{ get; set; }
        public PlotOptions PlotOptions { get; set; }
        public List<T> Series { get; set; }

        public ChartSettings()
        {
            Chart = new Chart();
            Series = new List<T>();
            name = DateTime.Now.ToString("c\\har\\t_HHmmssffffff");
        }

        internal void FixChartType()
        {
            Chart.RenderTo = "{0}_container".FormatWith(name);

            Type chartType = typeof(T);

            if (chartType == typeof(SeriesArea))
                Chart.Type = ChartTypes.Area;
            else if (chartType == typeof(SeriesArearange))
                Chart.Type = ChartTypes.Arearange;
            else if (chartType == typeof(SeriesAreaspline))
                Chart.Type = ChartTypes.Areaspline;
            else if (chartType == typeof(SeriesAreasplinerange))
                Chart.Type = ChartTypes.Areasplinerange;
            else if (chartType == typeof(SeriesBar))
                Chart.Type = ChartTypes.Bar;
            else if (chartType == typeof(SeriesBoxplot))
                Chart.Type = ChartTypes.Boxplot;
            else if (chartType == typeof(SeriesBubble))
                Chart.Type = ChartTypes.Bubble;
            else if (chartType == typeof(SeriesColumn))
                Chart.Type = ChartTypes.Column;
            else if (chartType == typeof(SeriesColumnrange))
                Chart.Type = ChartTypes.Columnrange;
            else if (chartType == typeof(SeriesErrorbar))
                Chart.Type = ChartTypes.Errorbar;
            else if (chartType == typeof(SeriesFunnel))
                Chart.Type = ChartTypes.Funnel;
            else if (chartType == typeof(SeriesGauge))
                Chart.Type = ChartTypes.Gauge;
            else if (chartType == typeof(SeriesHeatmap))
                Chart.Type = ChartTypes.Heatmap;
            else if (chartType == typeof(SeriesLine)) 
                Chart.Type = ChartTypes.Line;
            else if (chartType == typeof(SeriesPie))
                Chart.Type = ChartTypes.Pie;
            else if (chartType == typeof(SeriesPolygon))
                Chart.Type = ChartTypes.Polygon;
            else if (chartType == typeof(SeriesPyramid))
                Chart.Type = ChartTypes.Pyramid;
            else if (chartType == typeof(SeriesScatter))
                Chart.Type = ChartTypes.Scatter;
            else if (chartType == typeof(SeriesSolidgauge))
                Chart.Type = ChartTypes.Solidgauge;
            else if (chartType == typeof(SeriesSpline))
                Chart.Type = ChartTypes.Spline;
            else if (chartType == typeof(SeriesTreemap))
                Chart.Type = ChartTypes.Treemap;
            else if (chartType == typeof (SeriesWaterfall))
                Chart.Type = ChartTypes.Waterfall;

        }

    }
}
