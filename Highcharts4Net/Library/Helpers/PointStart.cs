using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Highcharts4Net.fastJSON;
//using Highcharts4Net.Library.Attributes;

namespace Highcharts4Net.Library.Helpers
{

    /// <summary>
    /// Defines on what value to start the series
    /// </summary>
    public class PointStart
    {
        /// <summary>
        /// Constructor with start point as date time
        /// </summary>
        /// <param name="pointStart"></param>
        public PointStart(DateTime pointStart) { PointStartDate = pointStart; }

        /// <summary>
        /// Constructor with start point as number
        /// </summary>
        /// <param name="pointStart"></param>
        public PointStart(Number pointStart) { PointStartNumber = pointStart; }

        private DateTime? PointStartDate { get; set; }

        private Number? PointStartNumber { get; set; }

        public override string ToString()
        {
            if (PointStartDate != null)
            {
                return JSON.ToJSON(PointStartDate);
            }
            return (PointStartNumber != null) ? JSON.ToJSON(PointStartNumber) : "";
        }
    }
}
