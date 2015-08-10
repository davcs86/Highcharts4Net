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
    public class ExtensionsLibrary : IDisposable
    {
        private HtmlHelper helper;

        internal ExtensionsLibrary(HtmlHelper helper)
        {
            this.helper = helper;
        }

        public MvcHtmlString GetLibraryScripts()
        {
            return
                new MvcHtmlString("<script src='" +
                                  UrlHelper.GenerateContentUrl("~/highcharts.hc4x", helper.ViewContext.HttpContext) +
                                  "'></script>");
        }

        public HighchartsRender AreaChart(Action<ChartSettings> settings)
        {
            var chart = new HighchartsRender();
            chart.CreateChart(settings, ChartTypes.Area);
            return chart;
        }


        public HighchartsRender LineChart(Action<ChartSettings> settings)
        {
            var chart = new HighchartsRender();
            chart.CreateChart(settings, ChartTypes.Line);
            return chart;
        }

        public HighchartsRender SplineChart(Action<ChartSettings> settings)
        {
            var chart = new HighchartsRender();
            chart.CreateChart(settings, ChartTypes.Spline);
            return chart;
        }

        public void Dispose()
        {
            helper = null;
        }
    }
}
