using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// HTML labels that can be positioned anywhere in the chart area.
	/// </summary>
	public class Labels
	{
		/// <summary>
		/// A HTML label that can be positioned anywhere in the chart area.
		/// </summary>
		public LabelsItems[] Items { get; set; }

		/// <summary>
		/// Shared CSS styles for all labels. Defaults to:<pre>style: { color: '#3E576F'}</pre>
		/// </summary>
		//[JsonFormatter("{{ {0} }}")]
		public CSSObject Style { get; set; }

	}

}