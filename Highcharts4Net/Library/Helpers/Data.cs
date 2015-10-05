using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Options;



namespace Highcharts4Net.Library.Helpers
{
    public class Data
    {
        public Data(object[] data) { ArrayData = data; }

        public Data(object[,] data) { DoubleArrayData = data; }

        public Data(Point[] data) { Points = data; }

        public Data(SeriesData[] data) { SeriesData = data; }

        public Data(Number?[] data)
        {
            ArrayData = new object[data.Length];
            data.CopyTo(ArrayData, 0);
        }

        public Data(Number?[,] data)
        {
            DoubleArrayData = new object[data.GetLength(0), data.GetLength(1)];
            data.CopyTo(DoubleArrayData, 0);
        }

        private object[] ArrayData { get; }

        private object[,] DoubleArrayData { get; }

        private Point[] Points { get; }

        private SeriesData[] SeriesData { get; }

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