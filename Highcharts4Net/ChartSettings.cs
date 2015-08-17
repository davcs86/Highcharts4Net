using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    public class ChartSettings
    {
        [System.Xml.Serialization.XmlIgnore]
        public string name { get; set; }

        public Chart Chart { get; }
        public Credits Credits { get; set; }
        public Legend Legend { set; get; }
        public Title Title { set; get; }
        public Subtitle Subtitle { set; get; }

        public XAxis XAxis { get; set; }
        public YAxis YAxis { get; set; }

        public Tooltip Tooltip{ get; set; }
        public PlotOptions PlotOptions { get; set; }
        public Series[] Series { get; set; }

        public ChartSettings()
        {
            Chart = new Chart();
            //Chart.Style = new List<string>();
            name = DateTime.Now.ToString("c\\har\\t_HHmmssffffff");
            Chart.RenderTo = "{0}_container".FormatWith(name);
        }

    }
}
