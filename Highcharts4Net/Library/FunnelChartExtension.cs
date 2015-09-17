﻿using System;
using System.Web;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{
    public delegate void SerieFunnelSettings(SeriesFunnel s);
    public sealed class FunnelChartSettings : BaseChartSettings<SeriesFunnel>
    {
        public void AddSeries(SerieFunnelSettings s)=>AddSeries(s, new SeriesFunnel());
    }

    public sealed class FunnelChartExtension : BaseChartExtension<FunnelChartSettings>
    {
        public FunnelChartExtension(Action<FunnelChartSettings> applySettings) : base(applySettings) { }

        public override HtmlString Render()
        {
            return ChartSettings.Settings.Render();
        }
    }
}