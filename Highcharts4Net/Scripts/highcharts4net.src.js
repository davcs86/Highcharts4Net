"use strict";
var H4N = function() {
	this.f = this.c = [];
	this.Init();
}
H4N.prototype.AddEventListener = function (obj, evt, fnc) {
    if (obj.addEventListener) { // W3C model
        obj.addEventListener(evt, fnc, false); return true;
    } else if (obj.attachEvent) { // Microsoft model
        return obj.attachEvent("on" + evt, fnc);
    }
    return false;
}
H4N.prototype.Init = function() {
	var that = this;
	this.AddEventListener(window, "load", function () {
    	that.RenderCharts();
    });
}
H4N.prototype.RegisterChart = function (chart) {
    if (typeof chart !== "undefined") {
        this.c.push(chart); // register charts
    }
}
H4N.prototype.RegisterCallback = function (callback) {
    if (typeof callback !== "undefined") {
        this.f.push(callback); // register callbacks
    }
}
H4N.prototype.RenderCharts = function () {
    for (var i in this.c) {
        if ("undefined" !== typeof this.c[i]) {
            var newchart = this.c[i].call(null);
            for (var j in this.f) {
                if ("undefined" !== typeof this.f[j]) {
                    this.f[j].apply(this.f[j], newchart);
                }
            }
        }
    }
}
var Highcharts4Net = new H4N();