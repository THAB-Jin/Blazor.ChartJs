using ChartJsWrapper.Common.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    public class GridLines
    {
        /// If false, do not display grid lines for this axis.
        public bool? Display { get; set; }

        /// If true, gridlines are circular (on radar chart only).
        public bool? Circular { get; set; }

        /// The color of the grid lines. If specified as an array, the first color applies to the first grid line, the second to the second grid line and so on.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        public IndexableOption<string> Color { get; set; }

        /// Length and spacing of dashes on grid lines
        /// <para>See <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash"/> for patterns and details</para>
        public double[] BorderDash { get; set; }

        /// Stroke width of grid lines.
        public IndexableOption<double> LineWidth { get; set; }

        /// If true, draw border at the edge between the axis and the chart area.
        public bool? DrawBorder { get; set; }

        /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn.
        public bool? DrawOnChartArea { get; set; }

        /// If true, draw lines beside the ticks in the axis area beside the chart.
        public bool? DrawTicks { get; set; }

        /// Length in pixels that the grid lines will draw into the axis area.
        public int? TickMarkLength { get; set; }

        /// Stroke width of the grid line for the first index (index 0).
        public int? ZeroLineWidth { get; set; }

        /// Stroke color of the grid line for the first index (index 0).
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        public string ZeroLineColor { get; set; }

        /// Length and spacing of dashes of the grid line for the first index (index 0).
        /// <para>See <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash"/> for details.</para>
        public double[] ZeroLineBorderDash { get; set; }

        /// Offset for line dashes of the grid line for the first index (index 0).
        /// <para>See <a href="https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset"/> for details.</para>
        public double? ZeroLineBorderDashOffset { get; set; }

        /// If true, grid lines will be shifted to be between labels. This is set to true for a category scale in a bar chart by default.
        public bool? OffsetGridLines { get; set; }
    }
}
