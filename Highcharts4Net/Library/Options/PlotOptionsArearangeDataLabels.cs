using System;
using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Extended data labels for range series types. Range series  data labels have no <code>x</code> and <code>y</code> options. Instead, they have <code>xLow</code>, <code>xHigh</code>, <code>yLow</code> and <code>yHigh</code> options to allow the higher and lower data label sets individually. 
	/// </summary>
    public class PlotOptionsArearangeDataLabels : PlotOptionsAreaDataLabels
	{

        private new Number? Y { get; set; }
        private new Number? X { get; set; }

        /// <summary>
        /// X offset of the higher data labels relative to the point value. 
        /// Default: 0
        /// </summary>
        public Number? XHigh { get; set; }

        /// <summary>
        /// X offset of the lower data labels relative to the point value.  
        /// Default: 0
        /// </summary>
        public Number? XLow { get; set; }

        /// <summary>
        /// Y offset of the higher data labels relative to the point value. 
        /// Default: -6
        /// </summary>
        public virtual Number? YHigh { get; set; }

        /// <summary>
        /// Y offset of the lower data labels relative to the point value.
        /// Default: -6
        /// </summary>
        public virtual Number? YLow { get; set; }

	}

}