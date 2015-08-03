using System;
using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	public class PlotOptionsAreaMarkerStates
	{
		public PlotOptionsAreaMarkerStatesHover Hover { get; set; }

		/// <summary>
		/// The appearance of the point marker when selected. In order to allow a point to be  selected, set the <code>series.allowPointSelect</code> option to true.
		/// </summary>
		public PlotOptionsAreaMarkerStatesSelect Select { get; set; }

	}

}