using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Highcharts4Net.Library.Helpers
{
    public class JSFunction
    {
        public JSFunction(string x)
        {
            _JSFunction = x;
        }

        private string _JSFunction { get; }

        public override string ToString()
        {
            return _JSFunction;
        }
        
        public static implicit operator JSFunction(string x)
        {
            JSFunction s = new JSFunction(x);
            return s;
        }

        public static explicit operator string (JSFunction x)
        {
            return x._JSFunction;
        }
    }
}
