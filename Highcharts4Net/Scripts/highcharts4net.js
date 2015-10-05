var Highcharts4Net = (function () {
    "use strict";
    var _f, _c;
    var _addEventListener = function (obj, evt, fnc) {
        // W3C model
        if (obj.addEventListener) {
            obj.addEventListener(evt, fnc, false); return true;
        } else if (obj.attachEvent) {
            // Microsoft model
            return obj.attachEvent('on' + evt, fnc);
        }
    }
    
    var _registerChart = function (chart) {
        if (typeof (chart) != "undefined") {
            _c.push(chart); // register charts
        }
    }
    var _registerCallback = function (callback) {
        if (typeof (callback) != "undefined") {
            _f.push(callback); // register callbacks
        }
    }
    var _renderCharts = function () {
        for (var i in _c) {
            var newchart = _c[i]();
            for (var j in _f) {
                if (_f.hasOwnProperty(j)) {
                    _f[j].apply(_f[j], newchart);
                }
            }
        }
    }
    var _init = function () {
        _f = [];
        _c = [];
        _addEventListener(window, "load", function () {
            _renderCharts();
        });
    }
    return {
        Init: function() {
            _init();
        },
        RegisterChart: function (chart) {
            _registerChart(chart);
        },
        RegisterCallback: function (callback) {
            _registerCallback(callback);
        }
    }
}());
Highcharts4Net.Init();
