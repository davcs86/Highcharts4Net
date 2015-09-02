using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Highcharts4Net_demos.Controllers
{
    public class LineChartsController : Controller
    {
        // GET: ~/LineCharts
        public ActionResult Index()
        {
            return RedirectToAction("Index","Inicio");
        }
        // GET: ~/LineCharts/Basic
        public ActionResult Basic()
        {
            return View();
        }
        // GET: ~/LineCharts/AjaxLoadedClickablePoints
        public ActionResult AjaxLoadedClickablePoints()
        {
            return View();
        }
    }
}