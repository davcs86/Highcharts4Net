﻿using System;
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

        public ColorOrGradient(Gradient gradient) { Gradient = gradient; }

        public ColorOrGradient(Color _color) { color = (new LiteralString(_color.ToRGBAString())).ToString(); }

        private string color { get; }

        private Gradient Gradient { get; }

        public override string ToString()
        {
            return Gradient?.ToString() ?? color;
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
        public NumberOrDateTime Cx { get; set; }
        public NumberOrDateTime Cy { get; set; }
        public NumberOrDateTime R { get; set; }
    }

    public class LinearGradient
    {
        public NumberOrDateTime X1 { get; set; }
        public NumberOrDateTime Y1 { get; set; }
        public NumberOrDateTime X2 { get; set; }
        public NumberOrDateTime Y2 { get; set; }
    }
}