using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common.Handlers;
using ChartJsWrapper.Interop;

namespace ChartJsWrapper.Common.Options
{
    public class Legend
    {
        public bool? Display { get; set; }
        public Positions Position { get; set; }
        public bool? FullWidth { get; set; }
        public IMethodHandler<LegendItemMouseEvent> OnClick { get; set; }
        public IMethodHandler<LegendItemMouseEvent> OnHover { get; set; }
        public bool? Reverse { get; set; }
        public LegendLabels Labels { get; set; }
    }
}
