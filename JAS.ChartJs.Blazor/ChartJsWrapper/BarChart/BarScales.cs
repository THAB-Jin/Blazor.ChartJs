using Newtonsoft.Json;
using ChartJsWrapper.Common.Axes;

namespace ChartJsWrapper.BarChart
{
    public class BarScales
    {
        [JsonProperty("xAxes")]
        public IList<CartesianAxis> XAxes { get; set; }

        [JsonProperty("yAxes")]
        public IList<CartesianAxis> YAxes { get; set; }
    }
}
