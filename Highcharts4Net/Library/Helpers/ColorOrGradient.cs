using System;
using System.Collections.Generic;
using System.Drawing;
using Highcharts4Net.fastJSON;

namespace Highcharts4Net.Library.Helpers
{
    public class ColorOrGradient
    {
        internal ColorOrGradient()
        {
        }

        public ColorOrGradient(string rawColor, bool escape = true) { color = (new LiteralString(rawColor, escape)).ToString(); }

        public ColorOrGradient(Gradient _gradient) { gradient = _gradient; }

        public ColorOrGradient(Color _color) { color = (new LiteralString(_color.ToRGBAString())).ToString(); }

        private string color { get; }

        private Gradient gradient { get; }

        public override string ToString()
        {
            return gradient?.ToString() ?? color;
        }
    }

    public class GradientStops
    {
        private readonly object[] _stops;
        public GradientStops(int n, ColorOrGradient color)
        {
            _stops = new object[] {n, color};
        }

        public override string ToString()
        {
            return JSON.ToJSON(_stops,
                    new JSONParameters
                    {
                        EnableAnonymousTypes = true,
                        SerializeNullValues = false,
                        UseEscapedUnicode = true,
                        SerializeToLowerFirstLetterNames = true,
                        SerializeToLowerFirstLetterEnums = true
                    });
        }
    }

    public class Gradient
    {
        public LinearGradient LinearGradient { get; set; }
        public RadialGradient RadialGradient { get; set; }
        public List<GradientStops> Stops { get; set; }
        public override string ToString()
        {
            if (RadialGradient != null)
            {
                return JSON.ToJSON(new {RadialGradient, Stops},
                    new JSONParameters
                    {
                        EnableAnonymousTypes = true,
                        SerializeNullValues = false,
                        UseEscapedUnicode = true,
                        SerializeToLowerFirstLetterNames = true,
                        SerializeToLowerFirstLetterEnums = true
                    });
            }
            if (LinearGradient != null)
            {
                return JSON.ToJSON(new { LinearGradient, Stops },
                    new JSONParameters
                    {
                        EnableAnonymousTypes = true,
                        SerializeNullValues = false,
                        UseEscapedUnicode = true,
                        SerializeToLowerFirstLetterNames = true,
                        SerializeToLowerFirstLetterEnums = true
                    });
            }
            return string.Empty;
        }
    }

    public class RadialGradient
    {
        public HighchartsDataPoint Cx { get; set; }
        public HighchartsDataPoint Cy { get; set; }
        public HighchartsDataPoint R { get; set; }
    }

    public class LinearGradient
    {
        public HighchartsDataPoint X1 { get; set; }
        public HighchartsDataPoint Y1 { get; set; }
        public HighchartsDataPoint X2 { get; set; }
        public HighchartsDataPoint Y2 { get; set; }
    }
}