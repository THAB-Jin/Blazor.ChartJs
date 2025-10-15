using ChartJsWrapper.Common;
using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.RadarChart
{
    /// <summary>
    /// Represents the config for a radar chart.
    /// </summary>
    public class RadarConfig : ConfigBase<RadarOptions>
    {
        /// <summary>
        /// Creates a new instance of <see cref="RadarConfig"/>.
        /// </summary>
        public RadarConfig() : base(ChartType.Radar) { }
    }
}
