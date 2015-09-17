using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
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

    public delegate void TitleSettings(Title s);
    public delegate void SubtitleSettings(Subtitle s);
    public delegate void XAxisSettings(XAxis s);
    public delegate void YAxisSettings(YAxis s);
    public delegate void TooltipSettings(Tooltip s);
    public delegate void PlotOptionsSettings(PlotOptions s);

    internal sealed class HighchartObj<TU>
    {
        public Chart Chart { internal set; get; }
        public List<ColorOrGradient> Colors { get; set; }
        public Credits Credits { get; set; } //
        public DataOptions Data { get; set; } //
        public Drilldown<TU> Drilldown { set; get; } // 
        public Exporting Exporting { set; get; } // 
        public Labels Labels { set; get; } //
        public Legend Legend { set; get; } //
        public Loading Loading { set; get; } //
        public Navigation Navigation { set; get; } //
        public NoData NoData { set; get; } //
        public Pane Pane { set; get; } //
        public PlotOptions PlotOptions { get; set; }
        public List<ISeries> Series { get; set; }
        public Subtitle Subtitle { set; get; }
        public Title Title { set; get; }
        public Tooltip Tooltip { get; set; }
        public List<XAxis> XAxis { get; set; }
        public List<YAxis> YAxis { get; set; }
    }

    internal sealed class HighchartSettings<T> where T: ISeries
    {

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

        public void AddSeries(Delegate d, ISeries s)
        {
            if (_chart.Series == null)
            {
                _chart.Series = new List<ISeries>();
            }
            d.DynamicInvoke(s);
            _chart.Series.Add(s);
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

        public void SetExporting(ExportingSettings s)
        {
            _chart.Exporting = new Exporting();
            s(_chart.Exporting);
        }

        public void SetLabels(LabelsSettings s)
        {
            _chart.Labels = new Labels();
            s(_chart.Labels);
        }

        public void SetLegend(LegendSettings s)
        {
            _chart.Legend = new Legend();
            s(_chart.Legend);
        }

        public void SetLoading(LoadingSettings s)
        {
            _chart.Loading = new Loading();
            s(_chart.Loading);
        }

        public void SetNavigation(NavigationSettings s)
        {
            _chart.Navigation = new Navigation();
            s(_chart.Navigation);
        }

        public void SetNoData(NoDataSettings s)
        {
            _chart.NoData = new NoData();
            s(_chart.NoData);
        }

        public void SetPane(PaneSettings s)
        {
            _chart.Pane = new Pane();
            s(_chart.Pane);
        }

        public void SetPlotOptions(PlotOptionsSettings s)
        {
            _chart.PlotOptions = new PlotOptions();
            s(_chart.PlotOptions);
        }

        public void SetSubtitle(SubtitleSettings s)
        {
            _chart.Subtitle = new Subtitle();
            s(_chart.Subtitle);
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

        private static string ToStringSerializer(object data)
        {
            return data.ToString();
        }

        private static string ToStringDeserializer(string data)
        {
            throw new NotImplementedException();
        }

        public HighchartSettings()
        {
            _chart = new HighchartObj<T>{ Chart = new Chart()};

            Name = DateTime.Now.ToString("c\\har\\t_HHmmssffffff");

            JSON.RegisterCustomType(typeof(LiteralString), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(Number), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(Data), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(PointStart), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(ColorOrGradient), ToStringSerializer, ToStringDeserializer);
        }

        public HtmlString Render()
        {
            FixChartType();

            var chartOptions = JSON.ToJSON(_chart,
                new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });

            StringBuilder output = new StringBuilder();

            if (FixDataCSV())
            {
                output.AppendFormat("<div id='{0}'></div>\n" +
                                    "<script>" +
                                    "\n\tif(typeof({3})=='undefined'){{var {3} = [];}};" +
                                    "\n\tvar {1};\n\t{3}.push($.getJSON(\"{4}\",function({2}_data){{\n\t\t{1} = new Highcharts.Chart({2});\n\t}}));" +
                                    "\n</script>",
                                    _chart.Chart.RenderTo, Name, chartOptions, "hc4n_arr", _chart.Data.getJSONP);
            }
            else
            {
                output.AppendFormat("<div id='{0}'></div>\n" +
                                    "<script>" +
                                    "\n\tif(typeof({3})=='undefined'){{var {3} = [];}};" +
                                    "\n\tvar {1};\n\t{3}.push(function(){{\n\t\t{1} = new Highcharts.Chart({2});\n\t}});" +
                                    "\n</script>",
                                    _chart.Chart.RenderTo, Name, chartOptions, "hc4n_arr");
            }

            return new HtmlString(output.ToString());
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
        
        internal bool FixDataCSV()
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
