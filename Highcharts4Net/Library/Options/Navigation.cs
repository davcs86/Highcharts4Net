using System;
using System.Drawing;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Attributes;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
	/// <summary>
	/// A collection of options for buttons and menus appearing in the exporting module.
	/// </summary>
	public class Navigation
	{
		/// <summary>
		/// A collection of options for buttons appearing in the exporting module.
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }

		/// <summary>
		/// CSS styles for the hover state of the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to <pre>menuItemHoverStyle: { background: '#4572A5', color: '#FFFFFF'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string MenuItemHoverStyle { get; set; }

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to <pre>menuItemStyle: { padding: '0 5px', background: NONE, color: '#303030'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string MenuItemStyle { get; set; }

		/// <summary>
		/// CSS styles for the popup menu appearing by default when the export icon is clicked. This menu is rendered in HTML. Defaults to <pre>menuStyle: { border: '1px solid #A0A0A0', background: '#FFFFFF'}</pre>
		/// </summary>
		[JsonFormatter("{{ {0} }}")]
		public string MenuStyle { get; set; }

	}

}