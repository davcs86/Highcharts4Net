using System;

namespace Highcharts4Net.Library.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name) { Name = name; }
        public string Name { get; private set; }
    }
}