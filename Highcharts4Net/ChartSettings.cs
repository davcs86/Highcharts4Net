using System;
using System.Collections.Generic;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    internal sealed class HighchartObj<U>
    {
        public Chart Chart { internal set; get; }
        public List<ColorOrGradient> Colors { get; set; }
        public Credits Credits { get; set; } //
        public DataOptions Data { get; set; } //
        public Drilldown<U> Drilldown { set; get; } // 
        public Exporting Exporting { set; get; } // 
        public Labels Labels { set; get; } //
        public Legend Legend { set; get; } //
        public Loading Loading { set; get; } //
        public Navigation Navigation { set; get; } //
        public NoData NoData { set; get; } //
        public Pane Pane { set; get; } //
        public PlotOptions PlotOptions { get; set; }
        public List<U> Series { get; set; }
        public Subtitle Subtitle { set; get; }
        public Title Title { set; get; }
        public Tooltip Tooltip { get; set; }
        public List<XAxis> XAxis { get; set; }
        public List<YAxis> YAxis { get; set; }
    }

    public sealed class HighchartSettings<T>
    {
        public delegate void ChartSettings(Chart s);
        //public delegate void ColorsSettings(Colors s);
        public delegate void CreditsSettings(Credits s);
        public delegate void DataSettings(DataOptions s);

        public delegate void DrilldownSettings<V>(Drilldown<V> s);
        public delegate void ExportingSettings(Exporting s);
        public delegate void LabelsSettings(Labels s);
        public delegate void LegendSettings(Legend s);
        public delegate void LoadingSettings(Loading s);
        public delegate void NavigationSettings(Navigation s);
        public delegate void NoDataSettings(NoData s);
        public delegate void PaneSettings(Pane s);
        public delegate void SerieSettings<V>(V s);

        public delegate void TitleSettings(Title s);
        public delegate void SubtitleSettings(Subtitle s);
        public delegate void XAxisSettings(XAxis s);
        public delegate void YAxisSettings(YAxis s);
        public delegate void TooltipSettings(Tooltip s);
        public delegate void PlotOptionsSettings(PlotOptions s);

        private HighchartObj<T> _chart;

        public void AddColor(ColorOrGradient s)
        {
            if (_chart.Colors == null)
            {
                _chart.Colors = new List<ColorOrGradient>();
            }
            _chart.Colors.Add(s);
        }

        public void AddXAxis(XAxisSettings s)
        {
            if (_chart.XAxis == null)
            {
                _chart.XAxis = new List<XAxis>();
            }
            var xAxis = new XAxis();
            s(xAxis);
            _chart.XAxis.Add(xAxis);
        }

        public void AddYAxis(YAxisSettings s)
        {
            if (_chart.YAxis == null)
            {
                _chart.YAxis = new List<YAxis>();
            }
            var yAxis = new YAxis();
            s(yAxis);
            _chart.YAxis.Add(yAxis);
        }

        public void AddSeries(SerieSettings<T> s)
        {
            if (_chart.Series == null)
            {
                _chart.Series = new List<T>();
            }
            var serie = (T)Activator.CreateInstance(typeof(T));
            s(serie);
            _chart.Series.Add(serie);
        }

        public string Name { get; set; }

        public void SetChart(ChartSettings s)
        {
            s(_chart.Chart);
        }

        public void SetCredits(CreditsSettings s)
        {
            _chart.Credits=new Credits();
            s(_chart.Credits);
        }

        public void SetData(DataSettings s)
        {
            _chart.Data = new DataOptions();
            s(_chart.Data);
        }

        public void SetDrillDown(DrilldownSettings<T> s)
        {
            _chart.Drilldown = new Drilldown<T>();
            s(_chart.Drilldown);
        }





        public void SetLegend(LegendSettings s)
        {
            _chart.Legend = new Legend();
            s(_chart.Legend);
        }

        public void SetTitle(TitleSettings s)
        {
            _chart.Title = new Title();
            s(_chart.Title);
        }

        public void SetTooltip(TooltipSettings s)
        {
            _chart.Tooltip = new Tooltip();
            s(_chart.Tooltip);
        }

        public void SetSubtitle(SubtitleSettings s)
        {
            _chart.Subtitle = new Subtitle();
            s(_chart.Subtitle);
        }

        public void SetPlotOptions(PlotOptionsSettings s)
        {
            _chart.PlotOptions = new PlotOptions();
            s(_chart.PlotOptions);
        }

         internal HighchartObj<T> GetChart()
         {
             return _chart;
         }

        public HighchartSettings()
        {
            _chart = new HighchartObj<T>{ Chart = new Chart()};

            Name = DateTime.Now.ToString("c\\har\\t_HHmmssffffff");
        }

        internal void FixChartType()
        {
            _chart.Chart.RenderTo = string.Format("{0}_container",Name);

            Type chartType = typeof(T);

            if (chartType == typeof(SeriesArea))
                _chart.Chart.Type = ChartTypes.Area;
            else if (chartType == typeof(SeriesArearange))
                _chart.Chart.Type = ChartTypes.Arearange;
            else if (chartType == typeof(SeriesAreaspline))
                _chart.Chart.Type = ChartTypes.Areaspline;
            else if (chartType == typeof(SeriesAreasplinerange))
                _chart.Chart.Type = ChartTypes.Areasplinerange;
            else if (chartType == typeof(SeriesBar))
                _chart.Chart.Type = ChartTypes.Bar;
            else if (chartType == typeof(SeriesBoxplot))
                _chart.Chart.Type = ChartTypes.Boxplot;
            else if (chartType == typeof(SeriesBubble))
                _chart.Chart.Type = ChartTypes.Bubble;
            else if (chartType == typeof(SeriesColumn))
                _chart.Chart.Type = ChartTypes.Column;
            else if (chartType == typeof(SeriesColumnrange))
                _chart.Chart.Type = ChartTypes.Columnrange;
            else if (chartType == typeof(SeriesErrorbar))
                _chart.Chart.Type = ChartTypes.Errorbar;
            else if (chartType == typeof(SeriesFunnel))
                _chart.Chart.Type = ChartTypes.Funnel;
            else if (chartType == typeof(SeriesGauge))
                _chart.Chart.Type = ChartTypes.Gauge;
            else if (chartType == typeof(SeriesHeatmap))
                _chart.Chart.Type = ChartTypes.Heatmap;
            else if (chartType == typeof(SeriesLine))
                _chart.Chart.Type = ChartTypes.Line;
            else if (chartType == typeof(SeriesPie))
                _chart.Chart.Type = ChartTypes.Pie;
            else if (chartType == typeof(SeriesPolygon))
                _chart.Chart.Type = ChartTypes.Polygon;
            else if (chartType == typeof(SeriesPyramid))
                _chart.Chart.Type = ChartTypes.Pyramid;
            else if (chartType == typeof(SeriesScatter))
                _chart.Chart.Type = ChartTypes.Scatter;
            else if (chartType == typeof(SeriesSolidgauge))
                _chart.Chart.Type = ChartTypes.Solidgauge;
            else if (chartType == typeof(SeriesSpline))
                _chart.Chart.Type = ChartTypes.Spline;
            else if (chartType == typeof(SeriesTreemap))
                _chart.Chart.Type = ChartTypes.Treemap;
            else if (chartType == typeof (SeriesWaterfall))
                _chart.Chart.Type = ChartTypes.Waterfall;

        }

        public bool FixDataCSV()
        {
            if (_chart.Data != null)
            {
                if (!string.IsNullOrWhiteSpace(_chart.Data.getJSONP))
                {
                    _chart.Data.Csv = Name + "_data";
                    return true;
                }
                _chart.Data.Csv = string.Format("\"{0}\"", Name);
            }
            return false;
        }
    }

    
}
