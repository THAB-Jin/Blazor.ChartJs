using ChartJsWrapper.Common;
using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.PolarAreaChart
{
    /// <summary>
    /// Represents the config for a polar area chart.
    /// </summary>
    public class PolarAreaConfig : ConfigBase<PolarAreaOptions>
    {
        /// <summary>
        /// Creates a new instance of <see cref="PolarAreaConfig"/>.
        /// </summary>
        public PolarAreaConfig() : base(ChartType.PolarArea) { }
    }
}
