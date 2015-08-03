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

        public LineChart LineChart(Action<ChartSettings> settings)
        {
            return
                new LineChart(settings);
        }

        public void Dispose()
        {
            helper = null;
        }
    }
}
