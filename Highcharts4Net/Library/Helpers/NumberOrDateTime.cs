using System;
using System.Globalization;

namespace Highcharts4Net.Library.Helpers
{
    public struct HighchartsDataPoint : IComparable
    {
        private DateTime? _dateValue;
        private readonly bool _isDateTime;

        private double? _doubleValue;
        private readonly bool _isDouble;

        private int? _intValue;
        private readonly bool _isInt;

        private decimal? _decimalValue;
        private readonly bool _isDecimal;

        private float? _floatValue;
        private readonly bool _isFloat;

        private long? _longValue;
        private readonly bool _isLong;

        private LiteralString _stringValue;
        private readonly bool _isString;

        HighchartsDataPoint(DateTime? value)
        {
            _dateValue = value;
            _isDateTime = true;

            _doubleValue = null;
            _isDouble = false;

            _intValue = null;
            _isInt = false;

            _decimalValue = null;
            _isDecimal = false;

            _floatValue = null;
            _isFloat = false;

            _longValue = null;
            _isLong = false;

            _stringValue = null;
            _isString = false;
        }

        HighchartsDataPoint(double? value)
        {
            _dateValue = null;
            _isDateTime = false;

            _doubleValue = value;
            _isDouble = true;

            _intValue = null;
            _isInt = false;

            _decimalValue = null;
            _isDecimal = false;

            _floatValue = null;
            _isFloat = false;

            _longValue = null;
            _isLong = false;

            _stringValue = null;
            _isString = false;
        }

        HighchartsDataPoint(int? value)
        {
            _dateValue = null;
            _isDateTime = false;

            _doubleValue = null;
            _isDouble = false;

            _intValue = value;
            _isInt = true;

            _decimalValue = null;
            _isDecimal = false;

            _floatValue = null;
            _isFloat = false;

            _longValue = null;
            _isLong = false;

            _stringValue = null;
            _isString = false;
        }

        HighchartsDataPoint(decimal? value)
        {
            _dateValue = null;
            _isDateTime = false;

            _doubleValue = null;
            _isDouble = false;

            _intValue = null;
            _isInt = false;

            _decimalValue = value;
            _isDecimal = true;

            _floatValue = null;
            _isFloat = false;

            _longValue = null;
            _isLong = false;

            _stringValue = null;
            _isString = false;
        }

        HighchartsDataPoint(float? value)
        {
            _dateValue = null;
            _isDateTime = false;

            _doubleValue = null;
            _isDouble = false;

            _intValue = null;
            _isInt = false;

            _decimalValue = null;
            _isDecimal = false;

            _floatValue = value;
            _isFloat = true;

            _longValue = null;
            _isLong = false;

            _stringValue = null;
            _isString = false;
        }

        HighchartsDataPoint(long? value)
        {
            _dateValue = null;
            _isDateTime = false;

            _doubleValue = null;
            _isDouble = false;

            _intValue = null;
            _isInt = false;

            _decimalValue = null;
            _isDecimal = false;

            _floatValue = null;
            _isFloat = false;

            _longValue = value;
            _isLong = true;

            _stringValue = null;
            _isString = false;
        }

        HighchartsDataPoint(LiteralString value)
        {
            _dateValue = null;
            _isDateTime = false;

            _doubleValue = null;
            _isDouble = false;

            _intValue = null;
            _isInt = false;

            _decimalValue = null;
            _isDecimal = false;

            _floatValue = null;
            _isFloat = false;

            _longValue = null;
            _isLong = false;

            _stringValue = value;
            _isString = true;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!_isDateTime && !_isDouble && !_isInt && !_isDecimal && !_isFloat && !_isLong && !_isString)
                throw new ArgumentException("The value is not correct.");

            if (obj == null) return 1;

            IComparable comparer = _isDateTime
                ? _dateValue
                : (_isDouble
                    ? _doubleValue
                    : (_isInt ? _intValue : (_isDecimal ? (IComparable)_decimalValue : (_isFloat ? _floatValue : (_isLong ? _longValue : null)))));

            HighchartsDataPoint objectNumber = (HighchartsDataPoint)obj;

            if (_isString && objectNumber._isString)
            {
                return string.Compare(_stringValue.ToString(), objectNumber._stringValue.ToString());
            }
            else if (_isString && !objectNumber._isString)
            {
                var objectString = objectNumber.ToString();
                return string.Compare(_stringValue.ToString(), objectString);
            }
            else if (!_isString && objectNumber._isString)
            {
                var thisString = ToString();
                return string.Compare(thisString, objectNumber._stringValue.ToString());
            }
            else
            {
                return comparer.CompareTo(objectNumber._isDateTime
                    ? objectNumber._dateValue
                    : (objectNumber._isDouble
                        ? objectNumber._doubleValue
                        : (objectNumber._isInt ? objectNumber._intValue : (objectNumber._isDecimal ? (IComparable)objectNumber._decimalValue : (objectNumber._isFloat ? objectNumber._floatValue : (_isLong ? _longValue : null))))));
            }
        }

        #endregion

        public static implicit operator HighchartsDataPoint(double value) { return new HighchartsDataPoint(value); }
        public static implicit operator HighchartsDataPoint(int value) { return new HighchartsDataPoint(value); }
        public static implicit operator HighchartsDataPoint(decimal value) { return new HighchartsDataPoint(value); }
        public static implicit operator HighchartsDataPoint(float value) { return new HighchartsDataPoint(value); }
        public static implicit operator HighchartsDataPoint(long value) { return new HighchartsDataPoint(value); }
        public static implicit operator HighchartsDataPoint(DateTime value) { return new HighchartsDataPoint(value); }
        public static implicit operator HighchartsDataPoint(string value) { return new HighchartsDataPoint(new LiteralString(value)); }
        public static implicit operator HighchartsDataPoint(LiteralString value) { return new HighchartsDataPoint(value); }

        public static implicit operator LiteralString (HighchartsDataPoint a)
        {
            return a._stringValue;
        }

        public static implicit operator string(HighchartsDataPoint a)
        {
            return a._stringValue.ToString();
        }

        public static implicit operator DateTime? (HighchartsDataPoint a)
        {
            return a._dateValue;
        }

        public static implicit operator int? (HighchartsDataPoint a)
        {
            return a._intValue;
        }

        public static implicit operator double? (HighchartsDataPoint a)
        {
            return a._doubleValue;
        }

        public static implicit operator decimal? (HighchartsDataPoint a)
        {
            return a._decimalValue;
        }

        public static implicit operator float? (HighchartsDataPoint a)
        {
            return a._floatValue;
        }

        public static implicit operator long? (HighchartsDataPoint a)
        {
            return a._longValue;
        }

        public override string ToString()
        {
            if (_isDateTime && _dateValue.HasValue)
                return string.Format("Date.UTC({0},{1},{2},{3},{4},{5},{6})", _dateValue.Value.Year, _dateValue.Value.Month - 1, _dateValue.Value.Day, _dateValue.Value.Hour, _dateValue.Value.Minute, _dateValue.Value.Second, _dateValue.Value.Millisecond);
            if (_isDouble && _doubleValue.HasValue)
                return _doubleValue.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_isInt && _intValue.HasValue)
                return _intValue.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_isDecimal && _decimalValue.HasValue)
                return _decimalValue.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_isFloat && _floatValue.HasValue)
                return _floatValue.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_isLong && _longValue.HasValue)
                return _longValue.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_isString)
                return _stringValue.ToString();
            return "''";
        }

    }
}