using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net
{
    public class ChartSettings
    {
        public string Name { get; set; }

        public Chart Chart { get; private set; }

        public Legend Legend { set; get; }

        public Title Title { set; get; }
        public Subtitle SubTitle { set; get; }

        public ChartSettings()
        {
            Chart = new Chart();
            Name = DateTime.Now.ToString("HHmmssffffff");
        }
    }
}
