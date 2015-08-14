using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using fastJSON;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    public class HighchartsRender
    {
        private static ChartSettings ChartSettings;

        internal void CreateChart(Action<ChartSettings> getSettings, ChartTypes? Chart_Type)
        {
            ChartSettings = new ChartSettings();

            getSettings(ChartSettings);

            if (Chart_Type!=null)
                ChartSettings.Chart.Type = Chart_Type;

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
            
            var chartOptions = JSON.ToJSON(ChartSettings,
                new JSONParameters {EnableAnonymousTypes = true, SerializeNullValues = false, UseEscapedUnicode = true, SerializeToLowerFirstLetterNames = true});
            var chartContainer = "<div id='{0}'></div>\n<script>\n\tvar {1};\n\twindow.onload=function(){{\n\t\t{1} = new Highcharts.Chart({2});\n\t}};\n</script>".FormatWith(ChartSettings.Chart.RenderTo, ChartSettings.name, chartOptions);
            return new HtmlString(chartContainer);
        }

    }
}
