using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Enums;

namespace Highcharts4Net
{
    public static class Extensions
    {
        /*public static string FormatWith(this string format, params object[] parameters) { return string.Format(format, parameters); }

        public static string FormatWith(this string format, int? value)
        {
            if (value != null)
                return string.Format(format, value.Value.ToString(CultureInfo.InvariantCulture));
            return string.Empty;
        }

        internal static string FormatWith(this string format, ChartTypes? value)
        {
            if (value != null)
                return string.Format(format, value.Value.ToString().ToLowerInvariant());
            return string.Empty;
        }

        public static void Append(this StringBuilder sb, string value, int tabs)
        {
            string tabsInBuilder = String.Empty;
            for (int i = 0; i < tabs; i++)
                tabsInBuilder += "\t";

            sb.Append(tabsInBuilder + value);
        }

        public static void AppendLine(this StringBuilder sb, string value, int tabs)
        {
            string tabsInBuilder = String.Empty;
            for (int i = 0; i < tabs; i++)
                tabsInBuilder += "\t";

            sb.AppendLine(tabsInBuilder + value);
        }

        public static void AppendWidthCommaBefore(this StringBuilder sb, string value)
        {
            if (sb.Length > 0)
                sb.Append(", ");
            sb.Append(value);
        }

        public static void AppendWidthCommaBefore(this StringBuilder sb, int? value)
        {
            if (sb.Length > 0)
                sb.Append(", ");
            if (value != null)
                sb.Append(value.Value.ToString(CultureInfo.InvariantCulture));
        }*/

        public static string ToHexString(this Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        public static string ToRGBString(this Color c)
        {
            return "rgb(" + c.R + "," + c.G + "," + c.B + ")";
        }
        public static string ToRGBAString(this Color c)
        {
            return "rgba(" + c.R + "," + c.G + "," + c.B + "," + decimal.Round(c.A/255.0m,2).ToString("N2", CultureInfo.InvariantCulture) + ")";
        }
    }
}