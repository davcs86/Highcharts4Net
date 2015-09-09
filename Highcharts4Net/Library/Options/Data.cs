using System.Collections.Generic;
using System.Xml.Serialization;
using Highcharts4Net.Library.Helpers;

namespace Highcharts4Net.Library.Options
{
    /// <summary>
    /// <p>The Data module provides a simplified interface for adding data to a chart from sources like CVS, HTML tables or grid views. See also the tutorial article on the Data module.</p>
    /// <p>It requires the modules/data.js file to be loaded.</p>
    /// <p>Please note that the default way of adding data in Highcharts, without the need of a module, is through the series.data option.</p>
    /// </summary>
    public sealed class DataOptions
    {
        /// <summary>
        /// A two-dimensional array representing the input data on tabular form. This input can be used when the data is already parsed, for example from a grid view component. Each cell can be a string or number. If not switchRowsAndColumns is set, the columns are interpreted as series.
        /// </summary>
        public List<List<object>> Columns { get; set; }

        /// <summary>
        /// The callback that is evaluated when the data is finished loading, optionally from an external source, and parsed. The first argument passed is a finished chart options object, containing the series. These options can be extended with additional options and passed directly to the chart constructor.
        /// </summary>
        public LiteralString Complete { get; set; }

        /// <summary>
        /// A comma delimited string to be parsed. Related options are startRow, endRow, startColumn and endColumn to delimit what part of the table is used. The lineDelimiter and itemDelimiter options define the CSV delimiter formats.
        /// </summary>
        public LiteralString Csv { get; set; }

        /// <summary>
        /// JSONP url for ajax loaded data (example: http://www.highcharts.com/demo/line-ajax)
        /// Overrides the value of "CSV"
        /// </summary>
        [XmlIgnore]
        public string getJSONP { get; set; }
        
    }
}
