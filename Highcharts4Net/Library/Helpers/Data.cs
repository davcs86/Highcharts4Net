using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library.Helpers
{
    public sealed class Data
    {

        public Data(Point[] data) { Points = data; }

        public Data(SeriesData[] data) { seriesData = data; }

        public Data(NumberOrDateTime?[] data) { NumberData = data; }

        public Data(NumberOrDateTime?[][] data) { JaggedNumberData = data; }

        public Data(NumberOrDateTime?[,] data) { DoubleNumberData = data; }

        private NumberOrDateTime?[] NumberData { get; }

        private NumberOrDateTime?[][] JaggedNumberData { get; }

        private NumberOrDateTime?[,] DoubleNumberData { get; }

        private Point[] Points { get; }

        private SeriesData[] seriesData { get; }

        public override string ToString()
        {
            if (NumberData != null)
            {
                return JSON.ToJSON(NumberData);
            }
            if (DoubleNumberData != null)
            {
                return JSON.ToJSON(DoubleNumberData);
            }

            if (JaggedNumberData != null)
            {
                return JSON.ToJSON(JaggedNumberData);
            }
            if (Points != null)
            {
                return JSON.ToJSON(Points);
            }
            return seriesData != null ? JSON.ToJSON(seriesData) : "";
        }
    }
}