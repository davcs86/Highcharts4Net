using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Highcharts4Net.Library;
using Highcharts4Net.Library.Enums;
using Highcharts4Net.Library.Helpers;
using Highcharts4Net.Library.Options;

namespace Highcharts4Net_demos.Controllers
{
    public class AreaChartsController : Controller
    {
        //
        // GET: /Inicio/

        public ActionResult Basic()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart
                {
                    //Type = ChartTypes.Line,
                    MarginRight = 130,
                    MarginBottom = 25,
                    ClassName = "chart"
                })
                .SetTitle(new Title
                {
                    Text = "<b>Monthly Average Temperature</b>",
                    X = -20
                })
                .SetSubtitle(new Subtitle
                {
                    Text = "Source: WorldClimate.com",
                    X = -20
                })
                .SetXAxis(new XAxis { Categories = ChartsData.Categories })
                .SetYAxis(new YAxis
                {
                    Title = new YAxisTitle { Text = "Temperature (°C)" },
                    PlotLines = new[]
                    {
                        new YAxisPlotLines
                        {
                            Value = 0,
                            Width = 1,
                            Color = ColorTranslator.FromHtml("#808080")
                        }
                    }
                })
                .SetTooltip(new Tooltip
                {
                    Formatter = @"function() {
                                        return '<b>'+ this.series.name +'</b><br/>'+
                                    this.x +': '+ this.y +'°C';
                                }"
                })
                .SetLegend(new Legend
                {
                    Layout = Layouts.Vertical,
                    Align = HorizontalAligns.Right,
                    VerticalAlign = VerticalAligns.Top,
                    X = -10,
                    Y = 100,
                    BorderWidth = 0
                })
                .SetSeries(new[]
                {
                    new Series { Name = "Tokyo", Data = new Data(ChartsData.TokioData) },
                    new Series { Name = "New York", Data = new Data(ChartsData.NewYorkData) },
                    new Series { Name = "Berlin", Data = new Data(ChartsData.BerlinData) },
                    new Series { Name = "London", Data = new Data(ChartsData.LondonData) }
                }
                );

            ViewBag.Chart = chart;

            return View();
        }

    }
}
