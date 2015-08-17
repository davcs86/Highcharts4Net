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

namespace Highcharts4Net
{
    public sealed class ExtensionsLibrary
    {

        private static HtmlHelper _helper;
        private static HighchartsRender _chart;

        public ExtensionsLibrary(HtmlHelper helper)
        {
            _helper = helper;
            _chart = new HighchartsRender();
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

        public HighchartsRender AreaChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.area);
            return _chart;
        }

        public HighchartsRender ArearangeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.arearange);
            return _chart;
        }

        public HighchartsRender AreasplineChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.areaspline);
            return _chart;
        }

        public HighchartsRender BarChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.bar);
            return _chart;
        }

        public HighchartsRender BoxplotChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.boxplot);
            return _chart;
        }

        public static HighchartsRender BubbleChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.bubble);
            return _chart;
        }

        public static HighchartsRender ColumnChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.column);
            return _chart;
        }

        public static HighchartsRender ColumnrangeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.columnrange);
            return _chart;
        }

        public static HighchartsRender ErrorbarChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.errorbar);
            return _chart;
        }

        public static HighchartsRender FunnelChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.funnel);
            return _chart;
        }

        public static HighchartsRender GaugeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.gauge);
            return _chart;
        }

        public static HighchartsRender HeatmapChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.heatmap);
            return _chart;
        }

        public static HighchartsRender LineChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.line);
            return _chart;
        }

        public static HighchartsRender PieChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.pie);
            return _chart;
        }

        public static HighchartsRender PolygonChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.polygon);
            return _chart;
        }

        public static HighchartsRender PyramidChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.pyramid);
            return _chart;
        }

        public static HighchartsRender ScatterChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.scatter);
            return _chart;
        }

        public static HighchartsRender SolidgaugeChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.solidgauge);
            return _chart;
        }

        public static HighchartsRender SplineChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.spline);
            return _chart;
        }

        public static HighchartsRender TreemapChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.treemap);
            return _chart;
        }

        public static HighchartsRender WaterfallChart(Action<ChartSettings> settings)
        {
            _chart.CreateChart(settings, ChartTypes.waterfall);
            return _chart;
        }

        public static HighchartsRender GenericChart(Action<ChartSettings> settings)
        {
            return _chart;
        }
    }
}
