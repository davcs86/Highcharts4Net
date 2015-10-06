// ReSharper disable MissingHasOwnPropertyInForeach
var Highcharts4Net = (function () {
    "use strict";
    var f, c, addEventListener = function (obj, evt, fnc) {
        if (obj.addEventListener) { // W3C model
            obj.addEventListener(evt, fnc, false); return true;
        } else if (obj.attachEvent) { // Microsoft model
            return obj.attachEvent("on" + evt, fnc);
        }
        return false;
    }
    var registerChart = function (chart) {
        if (typeof chart !== "undefined") {
            c.push(chart); // register charts
        }
    }
    var registerCallback = function (callback) {
        if (typeof callback !== "undefined") {
            f.push(callback); // register callbacks
        }
    }
    var renderCharts = function () {
        for (var i in c) {
            if ("undefined" !== typeof c[i]) {
                var newchart = c[i]();
                for (var j in f) {
                    if ("undefined" !== typeof f[j]) {
                        f[j].apply(f[j], newchart);
                    }
                }
            }
        }
    }
    var init = function () {
        f = [];
        c = [];
        addEventListener(window, "load", function () {
            renderCharts();
        });
    }
    return {
        Init: function() {
            init();
        },
        RegisterChart: function (chart) {
            registerChart(chart);
        },
        RegisterCallback: function (callback) {
            registerCallback(callback);
        }
    }
}());
Highcharts4Net.Init();
// ReSharper restore MissingHasOwnPropertyInForeach