using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Highcharts4Net.Library.Helpers
{
    public struct Number : IComparable
    {
        double? _DoubleNumber;
        int? _IntNumber;
        decimal? _DecimalNumber;
        float? _FloatNumber;

        Number(double value)
        {
            _DoubleNumber = value;
            _IntNumber = null;
            _DecimalNumber = null;
            _FloatNumber = null;
        }

        Number(int value)
        {
            _IntNumber = value;
            _DoubleNumber = null;
            _DecimalNumber = null;
            _FloatNumber = null;
        }

        Number(decimal value)
        {
            _DecimalNumber = value;
            _DoubleNumber = null;
            _IntNumber = null;
            _FloatNumber = null;
        }

        Number(float value)
        {
            _DoubleNumber = null;
            _IntNumber = null;
            _DecimalNumber = null;
            _FloatNumber = value;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (_DoubleNumber == null && _IntNumber == null && _DecimalNumber == null && _FloatNumber == null)
                throw new ArgumentException("The number is not correct.");

            if (obj == null) return 1;

            IComparable comparer = (((IComparable) (_DoubleNumber ?? _IntNumber) ?? _DecimalNumber) ?? _FloatNumber);
            Number objectNumber = (Number)obj;
            return comparer.CompareTo((((IComparable)(objectNumber._DoubleNumber ?? objectNumber._IntNumber) ?? objectNumber._DecimalNumber) ?? objectNumber._FloatNumber));
        }

        #endregion

        public static implicit operator Number(double value) { return new Number(value); }
        public static implicit operator Number(int value) { return new Number(value); }
        public static implicit operator Number(decimal value) { return new Number(value); }
        public static implicit operator Number(float value) { return new Number(value); }

        public static Number? GetNumber(object o)
        {
            if (o is int)
                return new Number((int)o);
            if (o is decimal)
                return new Number((decimal)o);
            if (o is double)
                return new Number((double)o);
            if (o is float)
                return new Number((float)o);
            return null;
        }

        public static implicit operator int?(Number a)
        {
            try
            {
                if (a._IntNumber.HasValue)
                return a._IntNumber.Value;
            if (a._DecimalNumber.HasValue)
                return Convert.ToInt32(a._DecimalNumber.Value);
            if (a._DoubleNumber.HasValue)
                return Convert.ToInt32(a._DoubleNumber.Value);
            if (a._FloatNumber.HasValue)
                return Convert.ToInt32(a._FloatNumber.Value);
            }
            catch (Exception)
            {
                // ignored
            }
            return null;
        }

        public static implicit operator double?(Number a)
        {
            try
            {
                if (a._DoubleNumber.HasValue)
                return a._DoubleNumber;
            if (a._DecimalNumber.HasValue)
                return Convert.ToDouble(a._DecimalNumber.Value);
            if (a._IntNumber.HasValue)
                return Convert.ToDouble(a._IntNumber.Value);
            if (a._FloatNumber.HasValue)
                return Convert.ToDouble(a._FloatNumber.Value);
        }
            catch (Exception)
            {
                // ignored
            }
            return null;
        }

        public static implicit operator decimal?(Number a)
        {
            try
            {
                if (a._DecimalNumber.HasValue)
                    return a._DecimalNumber;
                if (a._DoubleNumber.HasValue)
                    return Convert.ToDecimal(a._DoubleNumber.Value);
                if (a._IntNumber.HasValue)
                    return Convert.ToDecimal(a._IntNumber.Value);
                if (a._FloatNumber.HasValue)
                    return Convert.ToDecimal(a._FloatNumber.Value);
            }
            catch (Exception)
            {
                // ignored
            }
            return null;
        }

        public static implicit operator float? (Number a)
        {
            try
            {
                if (a._FloatNumber.HasValue)
                    return a._FloatNumber;
                if (a._DoubleNumber.HasValue)
                    return float.Parse(a._DoubleNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat),
                        CultureInfo.InvariantCulture.NumberFormat);
                if (a._IntNumber.HasValue)
                    return float.Parse(a._IntNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat),
                        CultureInfo.InvariantCulture.NumberFormat);
                if (a._DecimalNumber.HasValue)
                    return float.Parse(a._DecimalNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat),
                        CultureInfo.InvariantCulture.NumberFormat);
            }
            catch (Exception)
            {
                // ignored
            }
            return null;
        }

        public override string ToString()
        {
            if (_DoubleNumber.HasValue)
                return _DoubleNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_IntNumber.HasValue)
                return _IntNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_DecimalNumber.HasValue)
                return _DecimalNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            if (_FloatNumber.HasValue)
                return _FloatNumber.Value.ToString(CultureInfo.InvariantCulture.NumberFormat);
            return string.Empty;
        }
    }
}