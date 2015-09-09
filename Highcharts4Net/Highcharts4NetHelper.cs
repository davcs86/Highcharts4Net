using System.Web.Mvc;

namespace Highcharts4Net
{
    public static class Highcharts4NetHelper
    {
        public static ExtensionsLibrary Highcharts4Net(this HtmlHelper htmlHelper)
        {
            return new ExtensionsLibrary(htmlHelper);
        }

    }
}
