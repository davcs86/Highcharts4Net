namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value.
	/// </summary>
	public class PlotOptionsBubble: OptionsBubbleBase
	{
        public PlotOptionsBubble()
        {
            // Sets default values for [ForceNullable] properties
            Threshold = 0;
        }
    }

}