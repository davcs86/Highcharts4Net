namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// The column range is a cartesian series type with higher and lower Y values along an X axis. Requires <code>highcharts-more.js</code>. To display horizontal bars, set <a href='#chart.inverted'>chart.inverted</a> to <code>true</code>.
	/// </summary>
	public class PlotOptionsColumnrange: OptionsColumnrangeBase
	{
        public PlotOptionsColumnrange()
        {
            // Sets default values for [ForceNullable] properties
            Threshold = 0;
        }
    }

}
