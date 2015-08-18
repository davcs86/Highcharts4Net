using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.UI;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    public sealed class ExtensionsLibrary
    {

        private static HtmlHelper _helper;

        public ExtensionsLibrary(HtmlHelper helper)
        {
            _helper = helper;
        }
        /// <summary>
        /// Returns the script tag to include Highcharts-all.js in your page.
        /// </summary>
        /// <returns></returns>
        public MvcHtmlString GetLibraryScripts()
        {
            return
                new MvcHtmlString("<script src='" +
                                  UrlHelper.GenerateContentUrl("~/highcharts.hc4x", _helper.ViewContext.HttpContext) +
                                  "'></script>");
        }

        public HighchartsRender<SeriesArea> AreaChart(Action<ChartSettings<SeriesArea>> settings)
        {
            var chart = new HighchartsRender<SeriesArea>();
            chart.CreateChart(settings, ChartTypes.Area);
            return chart;
        }

        public HighchartsRender<SeriesArearange> ArearangeChart(Action<ChartSettings<SeriesArearange>> settings)
        {
            var chart = new HighchartsRender<SeriesArearange>();
            chart.CreateChart(settings, ChartTypes.Arearange);
            return chart;
        }

        public HighchartsRender<SeriesAreaspline> AreasplineChart(Action<ChartSettings<SeriesAreaspline>> settings)
        {
            var chart = new HighchartsRender<SeriesAreaspline>();
            chart.CreateChart(settings, ChartTypes.Areaspline);
            return chart;
        }

        public HighchartsRender<SeriesAreasplinerange> AreasplinerangeChart(Action<ChartSettings<SeriesAreasplinerange>> settings)
        {
            var chart = new HighchartsRender<SeriesAreasplinerange>();
            chart.CreateChart(settings, ChartTypes.Areasplinerange);
            return chart;
        }
        
        public HighchartsRender<SeriesBar> BarChart(Action<ChartSettings<SeriesBar>> settings)
        {
            var chart = new HighchartsRender<SeriesBar>();
            chart.CreateChart(settings, ChartTypes.Bar);
            return chart;
        }
        /*
        public HighchartsRender BoxplotChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Boxplot);
            return _chart;
        }

        public static HighchartsRender BubbleChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Bubble);
            return _chart;
        }

        public static HighchartsRender ColumnChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Column);
            return _chart;
        }

        public static HighchartsRender ColumnrangeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Columnrange);
            return _chart;
        }

        public static HighchartsRender ErrorbarChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Errorbar);
            return _chart;
        }

        public static HighchartsRender FunnelChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Funnel);
            return _chart;
        }

        public static HighchartsRender GaugeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Gauge);
            return _chart;
        }

        public static HighchartsRender HeatmapChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Heatmap);
            return _chart;
        }

        public static HighchartsRender LineChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Line);
            return _chart;
        }

        public static HighchartsRender PieChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Pie);
            return _chart;
        }

        public static HighchartsRender PolygonChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Polygon);
            return _chart;
        }

        public static HighchartsRender PyramidChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Pyramid);
            return _chart;
        }

        public static HighchartsRender ScatterChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Scatter);
            return _chart;
        }

        public static HighchartsRender SolidgaugeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Solidgauge);
            return _chart;
        }

        public static HighchartsRender SplineChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Spline);
            return _chart;
        }

        public static HighchartsRender TreemapChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Treemap);
            return _chart;
        }

        public static HighchartsRender WaterfallChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.Waterfall);
            return _chart;
        }

        public static HighchartsRender GenericChart(Action<ChartSettings> settings)
        {
            return _chart;
        }*/
    }
}
