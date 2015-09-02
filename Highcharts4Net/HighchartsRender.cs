using System;
using System.Text;
using System.Web;
using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net
{
    public class HighchartsRender<T>
    {
        internal static HighchartSettings<T> ChartSettings;
        private bool addJSONP;

        internal HighchartsRender(Action<HighchartSettings<T>> setSettings)
        {
            ChartSettings = new HighchartSettings<T>();

            setSettings(ChartSettings);

            ChartSettings.FixChartType();

            addJSONP= ChartSettings.FixDataCSV();
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
            JSON.RegisterCustomType(typeof(ColorOrGradient), ToStringSerializer, ToStringDeserializer);

            var chartOptions = JSON.ToJSON(ChartSettings.GetChart(),
                new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });

            StringBuilder output = new StringBuilder();

            if (addJSONP)
            {
                output.AppendFormat("<div id='{0}'></div>\n" +
                                    "<script>" +
                                    "\n\tif(typeof({3})=='undefined'){{var {3} = [];}};" +
                                    "\n\tvar {1};\n\t{3}.push($.getJSON(\"{4}\",function({2}_data){{\n\t\t{1} = new Highcharts.Chart({2});\n\t}}));" +
                                    "\n</script>",
                                    ChartSettings.GetChart().Chart.RenderTo, ChartSettings.Name, chartOptions, "hc4n_arr", ChartSettings.GetChart().Data.getJSONP);
            }
            else
            {
                output.AppendFormat("<div id='{0}'></div>\n" +
                                    "<script>" +
                                    "\n\tif(typeof({3})=='undefined'){{var {3} = [];}};" +
                                    "\n\tvar {1};\n\t{3}.push(function(){{\n\t\t{1} = new Highcharts.Chart({2});\n\t}});" +
                                    "\n</script>",
                                    ChartSettings.GetChart().Chart.RenderTo, ChartSettings.Name, chartOptions, "hc4n_arr");
            }
            

            return new HtmlString(output.ToString());
        }

    }
}
