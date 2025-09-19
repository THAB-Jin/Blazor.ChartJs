using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common.Interop;
using ChartJsWrapper.Common.Handlers;

namespace ChartJsWrapper.Common.Options
{
    // Legen Label Configuration -> https://www.chartjs.org/docs/latest/configuration/legend.html#legend-label-configuration
    public class LegendLabels
    {
        public int? BoxWidth { get; set; }
        public int? BoxHeight { get; set; }
        public Font Font { get; set; }
        public int? Padding { get; set; }
        public IMethodHandler<LegendLabelsGenerator> GenerateLabels { get; set; }
        public IMethodHandler<LegendLabelFilter> Filter { get; set; }
        public bool? UsePointStyle { get; set; }
        public PointStyle PointStyle { get; set; }
        public string? TextAlign { get; set; }
        public int? PointStyleWidth { get; set; }
        public bool? UseBorderRadius { get; set; }
        public int BorderRaddious { get; set; }

    }
}
