using System;
using System.Globalization;
using Highcharts4Net.fastJSON;



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
        public PointStart(NumberOrDateTime pointStart) { PointStartNumber = pointStart; }

        private DateTime? PointStartDate { get;}

        private NumberOrDateTime? PointStartNumber { get;  }

        public override string ToString()
        {
            if (PointStartDate != null)
            {
                return string.Format("Date.UTC({0},{1},{2},{3},{4},{5})", PointStartDate.Value.Year, PointStartDate.Value.Month-1, PointStartDate.Value.Day,PointStartDate.Value.Hour, PointStartDate.Value.Minute, PointStartDate.Value.Second);
            }
            return (PointStartNumber != null) ? JSON.ToJSON(PointStartNumber) : "";
        }
    }
}
