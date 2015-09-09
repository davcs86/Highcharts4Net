using System;
using System.IO;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Highcharts4Net.Library;
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

        public AreasplinerangeChartExtension AreasplinerangeChart(Action<AreasplinerangeChartSettings> settings)
        {
            return new AreasplinerangeChartExtension(settings);
        }

        public BarChartExtension BarChart(Action<BarChartSettings> settings)
        {
            return new BarChartExtension(settings);
        }

        public BoxplotChartExtension BoxplotChart(Action<BoxplotChartSettings> settings)
        {
            return new BoxplotChartExtension(settings);
        }

        public BubbleChartExtension BubbleChart(Action<BubbleChartSettings> settings)
        {
            return new BubbleChartExtension(settings);
        }

        public ColumnChartExtension ColumnChart(Action<ColumnChartSettings> settings)
        {
            return new ColumnChartExtension(settings);
        }

        public ColumnrangeChartExtension ColumnrangeChart(Action<ColumnrangeChartSettings> settings)
        {
            return new ColumnrangeChartExtension(settings);
        }

        public ErrorbarChartExtension ErrorbarChart(Action<ErrorbarChartSettings> settings)
        {
            return new ErrorbarChartExtension(settings);
        }

        public FunnelChartExtension FunnelChart(Action<FunnelChartSettings> settings)
        {
            return new FunnelChartExtension(settings);
        }

        public GaugeChartExtension GaugeChart(Action<GaugeChartSettings> settings)
        {
            return new GaugeChartExtension(settings);
        }

        public HeatmapChartExtension HeatmapChart(Action<HeatmapChartSettings> settings)
        {
            return new HeatmapChartExtension(settings);
        }

        public LineChartExtension LineChart(Action<LineChartSettings> settings)
        {
            return new LineChartExtension(settings);
        }

        public PieChartExtension PieChart(Action<PieChartSettings> settings)
        {
            return new PieChartExtension(settings);
        }

        public PolygonChartExtension PolygonChart(Action<PolygonChartSettings> settings)
        {
            return new PolygonChartExtension(settings);
        }

        public PyramidChartExtension PyramidChart(Action<PyramidChartSettings> settings)
        {
            return new PyramidChartExtension(settings);
        }

        public ScatterChartExtension ScatterChart(Action<ScatterChartSettings> settings)
        {
            return new ScatterChartExtension(settings);
        }

        public SolidgaugeChartExtension SolidgaugeChart(Action<SolidgaugeChartSettings> settings)
        {
            return new SolidgaugeChartExtension(settings);
        }

        public SplineChartExtension SplineChart(Action<SplineChartSettings> settings)
        {
            return new SplineChartExtension(settings);
        }

        public TreemapChartExtension TreemapChart(Action<TreemapChartSettings> settings)
        {
            return new TreemapChartExtension(settings);
        }

        public WaterfallChartExtension WaterfallChart(Action<WaterfallChartSettings> settings)
        {
            return new WaterfallChartExtension(settings);
        }

        public GenericChartExtension MultiTypeChart(Action<GenericChartSettings> settings)
        {
            return new GenericChartExtension(settings);
        }
    }
}
