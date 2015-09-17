using System;
using System.Web;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net.Library
{

    public class BaseChartSettings<T> where T : ISeries
    {
        internal HighchartSettings<T> Settings { get; }

        public BaseChartSettings()
        {
            Settings = new HighchartSettings<T>();
        }

        public void AddColor(ColorOrGradient s)=>Settings.AddColor(s); 

        public void AddXAxis(XAxisSettings s)=>Settings.AddXAxis(s); 

        public void AddYAxis(YAxisSettings s)=>Settings.AddYAxis(s);

        protected void AddSeries(Delegate d, ISeries s) => Settings.AddSeries(d, s);

        public string Name
        {
            get { return Settings.Name; }
            set { Settings.Name = value; }
        }

        public void SetChart(ChartSettings s)=>Settings.SetChart(s);

        public void SetCredits(CreditsSettings s)=>Settings.SetCredits(s);

        public void SetData(DataSettings s)=>Settings.SetData(s);

        public void SetDrillDown(DrilldownSettings<T> s)=>Settings.SetDrillDown(s);

        public void SetExporting(ExportingSettings s)=>Settings.SetExporting(s);

        public void SetLabels(LabelsSettings s)=>Settings.SetLabels(s);

        public void SetLegend(LegendSettings s)=>Settings.SetLegend(s);

        public void SetLoading(LoadingSettings s)=>Settings.SetLoading(s);

        public void SetNavigation(NavigationSettings s)=>Settings.SetNavigation(s);

        public void SetNoData(NoDataSettings s)=>Settings.SetNoData(s);

        public void SetPane(PaneSettings s)=>Settings.SetPane(s);

        public void SetPlotOptions(PlotOptionsSettings s)=>Settings.SetPlotOptions(s);

        public void SetSubtitle(SubtitleSettings s)=>Settings.SetSubtitle(s);

        public void SetTitle(TitleSettings s)=>Settings.SetTitle(s);

        public void SetTooltip(TooltipSettings s)=>Settings.SetTooltip(s);

    }

    public class BaseChartExtension<T>
    {
        protected readonly T ChartSettings;

        public BaseChartExtension(Action<T> applySettings)
        {
            ChartSettings = (T) Activator.CreateInstance(typeof (T));
            applySettings(ChartSettings);
        }

        public virtual HtmlString Render()
        {
            return new HtmlString(string.Empty);
        }
    }
}
