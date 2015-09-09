using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Options;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Helpers
{
    public class Data
    {
        public Data(object[] data) { ArrayData = data; }

        public Data(object[,] data) { DoubleArrayData = data; }

        public Data(Point[] data) { Points = data; }

        public Data(SeriesData[] data) { SeriesData = data; }

        private object[] ArrayData { get; set; }

        private object[,] DoubleArrayData { get; set ; }

        private Point[] Points { get; set; }

        private SeriesData[] SeriesData { get; set; }

        public override string ToString()
        {
            if (ArrayData != null)
            {
                return JSON.ToJSON(ArrayData);
            }
            if (DoubleArrayData != null)
            {
                return JSON.ToJSON(DoubleArrayData);
            }
            if (Points != null)
            {
                return JSON.ToJSON(Points);
            }
            return SeriesData != null ? JSON.ToJSON(SeriesData) : "";
        }
    }
}