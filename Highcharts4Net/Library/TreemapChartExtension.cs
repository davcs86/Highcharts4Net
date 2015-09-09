﻿using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public sealed class TreemapChartSettings : BaseChartSettings<SeriesTreemap> { }

    public sealed class TreemapChartExtension : BaseChartExtension<TreemapChartSettings>
    {
        public TreemapChartExtension(Action<TreemapChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}