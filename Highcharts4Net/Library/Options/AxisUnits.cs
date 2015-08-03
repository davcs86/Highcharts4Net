using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Options
{
    public class AxisUnits
    {
        [JsonFormatter("'{0}'")]
        public AxisUnitsType Type { get; set; }

        [JsonFormatter("[{0}]")]
        public Number[] Values { get; set; }

    }
}
