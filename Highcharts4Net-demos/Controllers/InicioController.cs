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
    public class InicioController : Controller
    {
        //
        // GET: /Inicio/

        public ActionResult Index()
        {
            return View();
        }

    }
}
