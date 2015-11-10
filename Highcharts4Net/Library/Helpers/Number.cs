using System;
using System.Globalization;

namespace Highcharts4Net.Library.Helpers
{
    public struct NumberOrDateTime : IComparable
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

        NumberOrDateTime(DateTime? value)
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
        }

        NumberOrDateTime(double? value)
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
        }

        NumberOrDateTime(int? value)
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
        }

        NumberOrDateTime(decimal? value)
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
        }

        NumberOrDateTime(float? value)
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
        }

        NumberOrDateTime(long? value)
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
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (!_isDateTime && !_isDouble && !_isInt && !_isDecimal && !_isFloat && !_isLong)
                throw new ArgumentException("The value is not correct.");

            if (obj == null) return 1;

            IComparable comparer = _isDateTime
                ? _dateValue
                : (_isDouble
                    ? _doubleValue
                    : (_isInt ? _intValue : (_isDecimal ? (IComparable) _decimalValue : (_isFloat ? _floatValue : (_isLong ? _longValue : null)))));

            NumberOrDateTime objectNumber = (NumberOrDateTime)obj;
            return comparer.CompareTo(objectNumber._isDateTime
                ? objectNumber._dateValue
                : (objectNumber._isDouble
                    ? objectNumber._doubleValue
                    : (objectNumber._isInt ? objectNumber._intValue : (objectNumber._isDecimal ? (IComparable)objectNumber._decimalValue : (objectNumber._isFloat ? objectNumber._floatValue : (_isLong ? _longValue : null))))));
        }

        #endregion

        public static implicit operator NumberOrDateTime(double value) { return new NumberOrDateTime(value); }
        public static implicit operator NumberOrDateTime(int value) { return new NumberOrDateTime(value); }
        public static implicit operator NumberOrDateTime(decimal value) { return new NumberOrDateTime(value); }
        public static implicit operator NumberOrDateTime(float value) { return new NumberOrDateTime(value); }
        public static implicit operator NumberOrDateTime(long value) { return new NumberOrDateTime(value); }
        public static implicit operator NumberOrDateTime(DateTime value) { return new NumberOrDateTime(value); }

        public static implicit operator DateTime? (NumberOrDateTime a)
        {
            return a._dateValue;
        }

        public static implicit operator int?(NumberOrDateTime a)
        {
            return a._intValue;
        }

        public static implicit operator double?(NumberOrDateTime a)
        {
            return a._doubleValue;
        }

        public static implicit operator decimal?(NumberOrDateTime a)
        {
            return a._decimalValue;
        }

        public static implicit operator float? (NumberOrDateTime a)
        {
            return a._floatValue;
        }

        public static implicit operator long? (NumberOrDateTime a)
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
            return string.Empty;
        }

    }
}