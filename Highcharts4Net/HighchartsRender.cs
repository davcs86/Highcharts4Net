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
        private static Highcharts _chart;
        private static ChartSettings ChartSS ;

        internal void CreateChart(Action<ChartSettings> getSettings, ChartTypes Chart_Type)
        {
            var _chartSettings = new ChartSettings();

            getSettings(_chartSettings);

            _chartSettings.chart.Type = Chart_Type;

            ChartSS = _chartSettings;

            applySettings(_chartSettings);
        }

        private void applySettings(ChartSettings settings)
        {
            _chart = new Highcharts(settings.Name)
                .InitChart(settings.chart)
                .SetTitle(settings.title)
                .SetSubtitle(settings.subTitle)
                .SetXAxis(settings.xAxis)
                .SetYAxis(settings.yAxis)
                .SetTooltip(settings.tooltip)
                .SetLegend(settings.legend);

        }

        private string LiteralStringSerializer(object data)
        {
            return data.ToString();
        }

        private string LiteralStringDeserializer(string data)
        {
            throw new NotImplementedException();
        }

        public HtmlString Render()
        {
            JSON.RegisterCustomType(typeof(LiteralString), LiteralStringSerializer, LiteralStringDeserializer);
            return new HtmlString(JSON.ToJSON(ChartSS, new JSONParameters { EnableAnonymousTypes = true, SerializeNullValues = false, UseEscapedUnicode = true}));
        }

    }
}
