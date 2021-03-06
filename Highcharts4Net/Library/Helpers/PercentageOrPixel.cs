﻿

namespace Highcharts4Net.Library.Helpers
{
    /// <summary>
    /// Specify the number like number of pixel or percentage.
    /// </summary>
    public class PercentageOrPixel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PercentageOrPixel"/> class.
        /// </summary>
        /// <param name="number">The number of pixel or percentage.</param>
        /// <param name="userPercentage">if set to <c>true</c> value as percentage.</param>
        public PercentageOrPixel(HighchartsDataPoint number, bool userPercentage = false)
        {
            if (userPercentage)
                Value = number + "%";
            else
                Value = number.ToString();
        }

        //
        public string Value { get; private set; }
    }
}