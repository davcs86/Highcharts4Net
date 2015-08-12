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
        public string Name { get; set; }

        public Chart chart { get; private set; }

        public Legend legend { set; get; }

        public Title title { set; get; }
        public Subtitle subTitle { set; get; }

        public XAxis xAxis { get; set; }
        public YAxis yAxis { get; set; }

        public Tooltip tooltip{ get; set; }

        public ChartSettings()
        {
            chart = new Chart();
            //Chart.Style = new List<string>();
            Name = DateTime.Now.ToString("c\\har\\t_HHmmssffffff");
        }

    }
}
