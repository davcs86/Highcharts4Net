using System;
using System.Drawing;
using Highcharts4Net.Library.Enums;
//using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// A wrapper object for all the series options in specific states.
	/// </summary>
	public class PlotOptionsPyramidStates
	{
		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsPyramidStatesHover Hover { get; set; }

	}

}