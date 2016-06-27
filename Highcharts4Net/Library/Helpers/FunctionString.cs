using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Highcharts4Net.fastJSON;

namespace Highcharts4Net.Library.Helpers
{
    public class FunctionString: LiteralString
    {
        public FunctionString(string x) : base(x, false){}

        public static implicit operator FunctionString(string x)
        {
            FunctionString s = new FunctionString(x);
            return s;
        }

        public static explicit operator string (FunctionString x)
        {
            return x._literalString;
        }

        public new string ToString()
        {
            return _literalString;
        }
    }
}
