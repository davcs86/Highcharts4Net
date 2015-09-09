namespace Highcharts4Net.Library.Helpers
{
    public class LiteralString
    {
        public LiteralString(string x)
        {
            _LiteralString = x;
        }

        private string _LiteralString { get; }

        public override string ToString()
        {
            return _LiteralString;
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
