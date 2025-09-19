using ChartJsWrapper.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Options
{
    // The model of the legend items which are displayed in the chart-legend.
    //https://www.chartjs.org/docs/latest/configuration/legend.html#legend-item-interface
    public class LegendItem
    {
        //Gets or sets the index of the dataset this legend item corresponds to.
        //DO NOT set this value when returning an instance of this class to Chart.js.
        //Only use this property when retrieving the index in a legend-event.
        //This value might not be set in charts that have legend labels per value
        //(instead of per dataset) like pie-chart.
        public int? DatasetIndex { get; set; }

        //Gets or sets the index of the value this legend item corresponds to.
        //DO NOT set this value when returning an instance of this class to Chart.js.
        //Only use this property when retrieving the index in a legend-event.
        //This value is only set in charts that have legend labels per value
        //(instead of per dataset) like pie-chart.
        public int? Index { get; set; }

        public int? BorderRadius { get; set; }


        public string Text { get; set; }

        public string FillStyle { get; set; }

        public string FontColor { get; set; }

        public bool? Hidden { get; set; }

        public BorderCapStyle LineCap { get; set; }

        // Details on
        //https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash

        public double[] LineDash { get; set; }

        // Details on
        //https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset

        public double? LineDashOffset { get; set; }


        public BorderJoinStyle LineJoin { get; set; }


        public double? LineWidth { get; set; }

        public string StrokeStyle { get; set; }


        public PointStyle PointStyle { get; set; }


        public double? Rotation { get; set; }
    }
}
