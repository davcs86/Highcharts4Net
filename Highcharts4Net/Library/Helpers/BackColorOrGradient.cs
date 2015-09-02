using System.Drawing;
using Highcharts4Net.fastJSON;

namespace Highcharts4Net.Library.Helpers
{
    public class ColorOrGradient
    {
        internal ColorOrGradient()
        {
        }

        public ColorOrGradient(LiteralString rawColor) { Color = rawColor.ToString(); }

        public ColorOrGradient(string color) { Color = string.Format("\"{0}\"",color); }

        public ColorOrGradient(Gradient gradient) { Gradient = gradient; }

        public ColorOrGradient(Color color) { Color = string.Format("\"{0}\"",color.ToRGBAString()); }

        private string Color { get; }

        private Gradient Gradient { get; }

        public override string ToString()
        {
            return Gradient?.ToString() ?? Color;
        }
    }

    public class Gradient
    {
        public int[] LinearGradient { get; set; }
        public RadialGradient RadialGradient { get; set; }
        public object[,] Stops { get; set; }
        public override string ToString()
        {
            if (RadialGradient != null)
            {
                return JSON.ToJSON(RadialGradient,
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
                return JSON.ToJSON(LinearGradient,
                    new JSONParameters
                    {
                        EnableAnonymousTypes = true,
                        SerializeNullValues = false,
                        UseEscapedUnicode = true,
                        SerializeToLowerFirstLetterNames = true,
                        SerializeToLowerFirstLetterEnums = true
                    });
            }
            return JSON.ToJSON(Stops,
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

    public class RadialGradient
    {
        public Number Cx { get; set; }
        public Number Cy { get; set; }
        public Number R { get; set; }
    }
}