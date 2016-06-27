using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library.Helpers
{
    public sealed class Data
    {

        public Data(object[] data) { ObjectData = data; }

        public Data(Point[] data) { Points = data; }

        public Data(SeriesData[] data) { SeriesData = data; }

        public Data(HighchartsDataPoint?[] data) { NumberData = data; }

        public Data(HighchartsDataPoint?[][] data) { JaggedNumberData = data; }

        public Data(HighchartsDataPoint?[,] data) { DoubleNumberData = data; }

        private object[] ObjectData { get; set; }

        private HighchartsDataPoint?[] NumberData { get; set; }

        private HighchartsDataPoint?[][] JaggedNumberData { get; set; }

        private HighchartsDataPoint?[,] DoubleNumberData { get; set; }

        private Point[] Points { get; set; }

        private SeriesData[] SeriesData { get; set; }

        public override string ToString()
        {
            if (NumberData != null)
            {
                return JSON.ToJSON(NumberData, new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });
            }
            if (DoubleNumberData != null)
            {
                return JSON.ToJSON(DoubleNumberData, new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });
            }

            if (JaggedNumberData != null)
            {
                return JSON.ToJSON(JaggedNumberData, new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });
            }
            if (Points != null)
            {
                return JSON.ToJSON(Points, new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });
            }
            if (SeriesData != null)
            {
                return JSON.ToJSON(SeriesData, new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });
            }
            if (ObjectData != null)
            {
                return JSON.ToJSON(ObjectData, new JSONParameters
                {
                    EnableAnonymousTypes = true,
                    SerializeNullValues = false,
                    UseEscapedUnicode = true,
                    SerializeToLowerFirstLetterNames = true,
                    SerializeToLowerFirstLetterEnums = true
                });
            }
            return "";
        }
    }
}