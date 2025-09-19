using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common;

namespace ChartJsWrapper.BarChart
{
    public class BarConfig : ChartConfigBase<BarOptions>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="BarConfig"/> class.
        /// </summary>
        /// <param name="horizontal">
        /// If <see langword="true"/>, the chart-type will be set to <see cref="ChartType.HorizontalBar"/>
        /// instead of <see cref="ChartType.Bar"/> which turns this chart into a horizontal
        /// bar chart. If set to <see langword="true"/>, you also have to pass in <see langword="true"/> for
        /// the <see cref="BarDataset{T}"/>s.
        /// </param>
        public BarConfig(bool horizontal = false) : base(horizontal ? ChartType.HorizontalBar : ChartType.Bar) { }
    }
}
