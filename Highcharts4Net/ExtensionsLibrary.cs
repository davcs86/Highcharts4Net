using System;
using System.IO;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Highcharts4Net.Library;

namespace Highcharts4Net
{

    public sealed class LibraryScriptsOptions
    {
        /// <summary>
        /// <i>True</i> for use Highcharts' official CDNs (http://code.highcharts.com/)
        /// </summary>
        public bool UseCDN { get; set; }
        /// <summary>
        /// Define the url path where the Highcharts' files are. Only taken when <b>UseCDN</b> is <i>false</i>.
        /// This value can be relative (using ~/)
        /// </summary>
        public string BasePath { get; set; }
        /// <summary>
        /// <i>True</i> for include highcharts-more.js
        /// </summary>
        public bool IncludeMore { get; set; }
        /// <summary>
        /// <i>True</i> for include modules/data.js
        /// Required for parsing data from csv.
        /// </summary>
        public bool IncludeModuleData { get; set; }
        /// <summary>
        /// <i>True</i> for include modules/exporting.js
        /// </summary>
        public bool IncludeModuleExporting { get; set; }
    }

    public sealed class ExtensionsLibrary
    {

        private static HtmlHelper _helper;

        public ExtensionsLibrary(HtmlHelper helper)
        {
            _helper = helper;
        }

        /// <summary>
        /// Returns the script tags to include Highcharts files in your page.
        /// </summary>
        /// <returns></returns>
        public HtmlString IncludeLibraryScripts(LibraryScriptsOptions options)
        {
            var context = _helper.ViewContext.HttpContext;
            string baseUrl = options.UseCDN
                ? context.Request.Url.Scheme+"://code.highcharts.com/"
                : UrlHelper.GenerateContentUrl(options.BasePath, context);

            var returnStr = string.Format("<script src='{0}'></script>\n", baseUrl+"highcharts.js");

            if(options.IncludeMore)
                returnStr += string.Format("<script src='{0}'></script>\n", baseUrl + "highcharts-more.js");
            if (options.IncludeModuleData)
                returnStr += string.Format("<script src='{0}'></script>\n", baseUrl + "modules/data.js");
            if (options.IncludeModuleExporting)
                returnStr += string.Format("<script src='{0}'></script>\n", baseUrl + "modules/exporting.js");

            // include custom code 
            var resource =
                Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("Highcharts4Net.Scripts.highcharts4net.js");
            if (resource != null)
            {
                var reader = new StreamReader(resource);
                returnStr += string.Format("<script>\n{0}\n</script>", reader.ReadToEnd());
            }

            return new MvcHtmlString(returnStr);
        }

        public AreaChartExtension AreaChart(Action<AreaChartSettings> settings) => new AreaChartExtension(settings);

        public ArearangeChartExtension ArearangeChart(Action<ArearangeChartSettings> settings) =>new ArearangeChartExtension(settings);

        public AreasplineChartExtension AreasplineChart(Action<AreasplineChartSettings> settings) =>new AreasplineChartExtension(settings);

        public AreasplinerangeChartExtension AreasplinerangeChart(Action<AreasplinerangeChartSettings> settings) => new AreasplinerangeChartExtension(settings);

        public BarChartExtension BarChart(Action<BarChartSettings> settings) => new BarChartExtension(settings);

        public BoxplotChartExtension BoxplotChart(Action<BoxplotChartSettings> settings) => new BoxplotChartExtension(settings);

        public BubbleChartExtension BubbleChart(Action<BubbleChartSettings> settings) => new BubbleChartExtension(settings);

        public ColumnChartExtension ColumnChart(Action<ColumnChartSettings> settings)=> new ColumnChartExtension(settings);

        public ColumnrangeChartExtension ColumnrangeChart(Action<ColumnrangeChartSettings> settings)=> new ColumnrangeChartExtension(settings);

        public ErrorbarChartExtension ErrorbarChart(Action<ErrorbarChartSettings> settings)=> new ErrorbarChartExtension(settings);

        public FunnelChartExtension FunnelChart(Action<FunnelChartSettings> settings)=> new FunnelChartExtension(settings);

        public GaugeChartExtension GaugeChart(Action<GaugeChartSettings> settings)=> new GaugeChartExtension(settings);

        public HeatmapChartExtension HeatmapChart(Action<HeatmapChartSettings> settings)=> new HeatmapChartExtension(settings);

        public LineChartExtension LineChart(Action<LineChartSettings> settings)=> new LineChartExtension(settings);

        public PieChartExtension PieChart(Action<PieChartSettings> settings)=> new PieChartExtension(settings);

        public PolygonChartExtension PolygonChart(Action<PolygonChartSettings> settings)=> new PolygonChartExtension(settings);

        public PyramidChartExtension PyramidChart(Action<PyramidChartSettings> settings)=> new PyramidChartExtension(settings);

        public ScatterChartExtension ScatterChart(Action<ScatterChartSettings> settings) => new ScatterChartExtension(settings);

        public SolidgaugeChartExtension SolidgaugeChart(Action<SolidgaugeChartSettings> settings) => new SolidgaugeChartExtension(settings);

        public SplineChartExtension SplineChart(Action<SplineChartSettings> settings) => new SplineChartExtension(settings);

        public TreemapChartExtension TreemapChart(Action<TreemapChartSettings> settings) => new TreemapChartExtension(settings);

        public WaterfallChartExtension WaterfallChart(Action<WaterfallChartSettings> settings) => new WaterfallChartExtension(settings);

        public GenericChartExtension MultiTypeChart(Action<GenericChartSettings> settings) => new GenericChartExtension(settings);
    }
}
