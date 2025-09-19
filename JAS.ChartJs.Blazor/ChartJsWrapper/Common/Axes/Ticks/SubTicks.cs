using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common;

namespace ChartJsWrapper.Common.Axes.Ticks
{
    // The ultimate base class for tick mark configurations.
    public abstract class SubTicks
    {
        public Font TickFont { get; set; }
        public double? LineHeight { get; set; }
    }
}
