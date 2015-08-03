using System;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library.Helpers
{
    public class Data
    {
        public Data(object[] data) { ArrayData = data; }

        public Data(object[,] data) { DoubleArrayData = data; }

        public Data(Point[] data) { Points = data; }

        public Data(SeriesData[] data) { SeriesData = data; }

        [Name("data")]
        public object[] ArrayData { get; private set; }

        [Name("data")]
        public object[,] DoubleArrayData { get; private set; }

        [Name("data")]
        public Point[] Points { get; private set; }

        [Name("data")]
        public SeriesData[] SeriesData { get; private set; }
    }
}