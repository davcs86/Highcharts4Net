using Highcharts4Net.Library.Helpers;



namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// Extended data labels for range series types. Range series  data labels have no <code>x</code> and <code>y</code> options. Instead, they have <code>xLow</code>, <code>xHigh</code>, <code>yLow</code> and <code>yHigh</code> options to allow the higher and lower data label sets individually. 
	/// </summary>
    public class PlotOptionsArearangeDataLabels : PlotOptionsAreaDataLabels
	{

        private new NumberOrDateTime? Y { get; set; }
        private new NumberOrDateTime? X { get; set; }

        /// <summary>
        /// X offset of the higher data labels relative to the point value. 
        /// Default: 0
        /// </summary>
        public NumberOrDateTime? XHigh { get; set; }

        /// <summary>
        /// X offset of the lower data labels relative to the point value.  
        /// Default: 0
        /// </summary>
        public NumberOrDateTime? XLow { get; set; }

        /// <summary>
        /// Y offset of the higher data labels relative to the point value. 
        /// Default: -6
        /// </summary>
        public virtual NumberOrDateTime? YHigh { get; set; }

        /// <summary>
        /// Y offset of the lower data labels relative to the point value.
        /// Default: -6
        /// </summary>
        public virtual NumberOrDateTime? YLow { get; set; }

	}

}