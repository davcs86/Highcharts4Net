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
using Highcharts4Net.Library;
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
        public HtmlString IncludeLibraryScripts()
        {
            return
                new MvcHtmlString("<script src='" +
                                  UrlHelper.GenerateContentUrl("~/highcharts.hc4x", _helper.ViewContext.HttpContext) +
                                  "'></script>");
        }

        /// <summary>
        /// Returns Highcharts-all.js inside a SCRIPT tag in your page.
        /// </summary>
        /// <returns></returns>
        public HtmlString PrintLibraryScripts()
        {
            var resource = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Highcharts4Net.Scripts.highcharts.js"));

            return
                new MvcHtmlString("<script>\n"+resource.ReadToEnd()+"\n</script>");
        }

        public AreaChartExtension AreaChart(Action<AreaChartSettings> settings)
        {
            return new AreaChartExtension(settings);
        }

        public ArearangeChartExtension ArearangeChart(Action<ArearangeChartSettings> settings)
        {
            return new ArearangeChartExtension(settings);
        }

        public AreasplineChartExtension AreasplineChart(Action<AreasplineChartSettings> settings)
        {
            return new AreasplineChartExtension(settings);
        }

        public HighchartsRender<SeriesAreasplinerange> AreasplinerangeChart(Action<HighchartSettings<SeriesAreasplinerange>> settings)
        {
            return new HighchartsRender<SeriesAreasplinerange>(settings);
        }

        public HighchartsRender<SeriesBar> BarChart(Action<HighchartSettings<SeriesBar>> settings)
        {
            return new HighchartsRender<SeriesBar>(settings);
        }

        public HighchartsRender<SeriesBoxplot> BoxplotChart(Action<HighchartSettings<SeriesBoxplot>> settings)
        {
            return new HighchartsRender<SeriesBoxplot>(settings);
        }

        public HighchartsRender<SeriesBubble> BubbleChart(Action<HighchartSettings<SeriesBubble>> settings)
        {
            return new HighchartsRender<SeriesBubble>(settings);
        }

        public HighchartsRender<SeriesColumn> ColumnChart(Action<HighchartSettings<SeriesColumn>> settings)
        {
            return new HighchartsRender<SeriesColumn>(settings);
        }

        public HighchartsRender<SeriesColumnrange> ColumnrangeChart(Action<HighchartSettings<SeriesColumnrange>> settings)
        {
            return new HighchartsRender<SeriesColumnrange>(settings);
        }

        public HighchartsRender<SeriesErrorbar> ErrorbarChart(Action<HighchartSettings<SeriesErrorbar>> settings)
        {
            return new HighchartsRender<SeriesErrorbar>(settings);
        }

        public HighchartsRender<SeriesFunnel> FunnelChart(Action<HighchartSettings<SeriesFunnel>> settings)
        {
            return new HighchartsRender<SeriesFunnel>(settings);
        }

        public HighchartsRender<SeriesGauge> GaugeChart(Action<HighchartSettings<SeriesGauge>> settings)
        {
            return new HighchartsRender<SeriesGauge>(settings);
        }

        public HighchartsRender<SeriesHeatmap> HeatmapChart(Action<HighchartSettings<SeriesHeatmap>> settings)
        {
            return new HighchartsRender<SeriesHeatmap>(settings);
        }

        public LineChartExtension LineChart(Action<LineChartSettings> settings)
        {
            return new LineChartExtension(settings);
        }

        public HighchartsRender<SeriesPie> PieChart(Action<HighchartSettings<SeriesPie>> settings)
        {
            return new HighchartsRender<SeriesPie>(settings);
        }

        public HighchartsRender<SeriesPolygon> PolygonChart(Action<HighchartSettings<SeriesPolygon>> settings)
        {
            return new HighchartsRender<SeriesPolygon>(settings);
        }

        public HighchartsRender<SeriesPyramid> PyramidChart(Action<HighchartSettings<SeriesPyramid>> settings)
        {
            return new HighchartsRender<SeriesPyramid>(settings);
        }

        public HighchartsRender<SeriesScatter> ScatterChart(Action<HighchartSettings<SeriesScatter>> settings)
        {
            return new HighchartsRender<SeriesScatter>(settings);
        }

        public HighchartsRender<SeriesSolidgauge> SolidgaugeChart(Action<HighchartSettings<SeriesSolidgauge>> settings)
        {
            return new HighchartsRender<SeriesSolidgauge>(settings);
        }

        public HighchartsRender<SeriesSpline> SplineChart(Action<HighchartSettings<SeriesSpline>> settings)
        {
            return new HighchartsRender<SeriesSpline>(settings);
        }

        public HighchartsRender<SeriesSpline> TreemapChart(Action<HighchartSettings<SeriesSpline>> settings)
        {
            return new HighchartsRender<SeriesSpline>(settings);
        }

        public HighchartsRender<SeriesWaterfall> WaterfallChart(Action<HighchartSettings<SeriesWaterfall>> settings)
        {
            return new HighchartsRender<SeriesWaterfall>(settings);
        }

        public HighchartsRender<ISeries> MultiTypeChart(Action<HighchartSettings<ISeries>> settings)
        {
            return new HighchartsRender<ISeries>(settings);
        }
    }
}
