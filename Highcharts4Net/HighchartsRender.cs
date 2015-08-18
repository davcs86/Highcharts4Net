using System;
using System.Web;
using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net
{
    public class HighchartsRender<T>
    {
        private static ChartSettings<T> ChartSettings;

        internal HighchartsRender(Action<ChartSettings<T>> getSettings)
        {
            ChartSettings = new ChartSettings<T>();

            getSettings(ChartSettings);

            ChartSettings.FixChartType();
        }

        private static string ToStringSerializer(object data)
        {
            return data.ToString();
        }

        private static string ToStringDeserializer(string data)
        {
            throw new NotImplementedException();
        }

        public HtmlString Render()
        {
            JSON.RegisterCustomType(typeof(LiteralString), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(Number), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(Data), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(PointStart), ToStringSerializer, ToStringDeserializer);
            JSON.RegisterCustomType(typeof(BackColorOrGradient), ToStringSerializer, ToStringDeserializer);

            var chartOptions = JSON.ToJSON(ChartSettings,
                new JSONParameters {EnableAnonymousTypes = true, SerializeNullValues = false, UseEscapedUnicode = true, SerializeToLowerFirstLetterNames = true, SerializeToLowerFirstLetterEnums = true});
            var chartContainer = "<div id='{0}'></div>\n<script>\n\tif(typeof({3})=='undefined'){{var {3} = [];}};\n\tvar {1};\n\t{3}.push(function(){{\n\t\t{1} = new Highcharts.Chart({2});\n\t}});\n</script>".FormatWith(ChartSettings.Chart.RenderTo, ChartSettings.name, chartOptions, "hc4n_arr");
            return new HtmlString(chartContainer);
        }

    }
}
