using System;
using System.Collections.Generic;
using Highcharts4Net.fastJSON;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library.Helpers
{
    public sealed class Data
    {

        public Data(object[] data) { ObjectData = data; }

        public Data(Point[] data) { Points = data; }

        public Data(SeriesData[] data) { seriesData = data; }

        public Data(NumberOrDateTime?[] data) { NumberData = data; }

        public Data(NumberOrDateTime?[][] data) { JaggedNumberData = data; }

        public Data(NumberOrDateTime?[,] data) { DoubleNumberData = data; }

        private object[] ObjectData { get; }

        private NumberOrDateTime?[] NumberData { get; }

        private NumberOrDateTime?[][] JaggedNumberData { get; }

        private NumberOrDateTime?[,] DoubleNumberData { get; }

        private Point[] Points { get; }

        private SeriesData[] seriesData { get; }

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
            if (seriesData != null)
            {
                return JSON.ToJSON(seriesData, new JSONParameters
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