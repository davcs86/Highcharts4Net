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
            return new HighchartsRender<SeriesArea>(settings);
        }

        public HighchartsRender<SeriesArearange> ArearangeChart(Action<ChartSettings<SeriesArearange>> settings)
        {
            return new HighchartsRender<SeriesArearange>(settings);
        }

        public HighchartsRender<SeriesAreaspline> AreasplineChart(Action<ChartSettings<SeriesAreaspline>> settings)
        {
            return new HighchartsRender<SeriesAreaspline>(settings);
        }

        public HighchartsRender<SeriesAreasplinerange> AreasplinerangeChart(Action<ChartSettings<SeriesAreasplinerange>> settings)
        {
            return new HighchartsRender<SeriesAreasplinerange>(settings);
        }
        
        public HighchartsRender<SeriesBar> BarChart(Action<ChartSettings<SeriesBar>> settings)
        {
            return new HighchartsRender<SeriesBar>(settings);
        }
        
        public HighchartsRender<SeriesBoxplot> BoxplotChart(Action<ChartSettings<SeriesBoxplot>> settings)
        {
            return new HighchartsRender<SeriesBoxplot>(settings);
        }

        public HighchartsRender<SeriesBubble> BubbleChart(Action<ChartSettings<SeriesBubble>> settings)
        {
            return new HighchartsRender<SeriesBubble>(settings);
        }

        public HighchartsRender<SeriesColumn> ColumnChart(Action<ChartSettings<SeriesColumn>> settings)
        {
            return new HighchartsRender<SeriesColumn>(settings);
        }

        public HighchartsRender<SeriesColumnrange> ColumnrangeChart(Action<ChartSettings<SeriesColumnrange>> settings)
        {
            return new HighchartsRender<SeriesColumnrange>(settings);
        }

        public HighchartsRender<SeriesErrorbar> ErrorbarChart(Action<ChartSettings<SeriesErrorbar>> settings)
        {
            return new HighchartsRender<SeriesErrorbar>(settings);
        }

        public HighchartsRender<SeriesFunnel> FunnelChart(Action<ChartSettings<SeriesFunnel>> settings)
        {
            return new HighchartsRender<SeriesFunnel>(settings);
        }

        public HighchartsRender<SeriesGauge> GaugeChart(Action<ChartSettings<SeriesGauge>> settings)
        {
            return new HighchartsRender<SeriesGauge>(settings);
        }

        public HighchartsRender<SeriesHeatmap> HeatmapChart(Action<ChartSettings<SeriesHeatmap>> settings)
        {
            return new HighchartsRender<SeriesHeatmap>(settings);
        }

        public HighchartsRender<SeriesLine> LineChart(Action<ChartSettings<SeriesLine>> settings)
        {
            return new HighchartsRender<SeriesLine>(settings);
        }

        public HighchartsRender<SeriesPie> PieChart(Action<ChartSettings<SeriesPie>> settings)
        {
            return new HighchartsRender<SeriesPie>(settings);
        }

        public HighchartsRender<SeriesPolygon> PolygonChart(Action<ChartSettings<SeriesPolygon>> settings)
        {
            return new HighchartsRender<SeriesPolygon>(settings);
        }

        public HighchartsRender<SeriesPyramid> PyramidChart(Action<ChartSettings<SeriesPyramid>> settings)
        {
            return new HighchartsRender<SeriesPyramid>(settings);
        }

        public HighchartsRender<SeriesScatter> ScatterChart(Action<ChartSettings<SeriesScatter>> settings)
        {
            return new HighchartsRender<SeriesScatter>(settings);
        }

        public HighchartsRender<SeriesSolidgauge> SolidgaugeChart(Action<ChartSettings<SeriesSolidgauge>> settings)
        {
            return new HighchartsRender<SeriesSolidgauge>(settings);
        }

        public HighchartsRender<SeriesSpline> SplineChart(Action<ChartSettings<SeriesSpline>> settings)
        {
            return new HighchartsRender<SeriesSpline>(settings);
        }

        public HighchartsRender<SeriesSpline> TreemapChart(Action<ChartSettings<SeriesSpline>> settings)
        {
            return new HighchartsRender<SeriesSpline>(settings);
        }

        public HighchartsRender<SeriesWaterfall> WaterfallChart(Action<ChartSettings<SeriesWaterfall>> settings)
        {
            return new HighchartsRender<SeriesWaterfall>(settings);
        }

        public HighchartsRender<ISeries> MultiTypeChart(Action<ChartSettings<ISeries>> settings)
        {
            return new HighchartsRender<ISeries>(settings);
        }
    }
}
