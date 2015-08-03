using System.Drawing;

namespace Highcharts4Net.Library.Helpers
{
    public class PointDrilldown
    {
        public string Name { get; set; }
        public string[] Categories { get; set; }
        public Data Data { get; set; }
        public Color Color { get; set; }
    }
}