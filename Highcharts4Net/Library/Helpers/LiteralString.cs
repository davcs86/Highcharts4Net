using Highcharts4Net.fastJSON;

namespace Highcharts4Net.Library.Helpers
{
    public class LiteralString
    {
        public LiteralString(string x, bool escape = true)
        {
            _LiteralString = x;
            _escape = escape;
        }

        protected string _LiteralString { get; }
        protected bool _escape { get; set; }

        internal void SetEscape(bool escape)
        {
            _escape = escape;
        }

        public override string ToString()
        {
            return (_escape)? JSON.ToJSON(_LiteralString,
                    new JSONParameters
                    {
                        EnableAnonymousTypes = true,
                        SerializeNullValues = false,
                        UseEscapedUnicode = true,
                        SerializeToLowerFirstLetterNames = true,
                        SerializeToLowerFirstLetterEnums = true
                    }):_LiteralString;
        }
        
        public static implicit operator LiteralString(string x)
        {
            LiteralString s = new LiteralString(x);
            return s;
        }

        public static explicit operator string (LiteralString x)
        {
            return x._LiteralString;
        }
    }
}
