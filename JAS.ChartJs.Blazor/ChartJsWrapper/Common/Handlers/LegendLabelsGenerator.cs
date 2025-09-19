using ChartJsWrapper.Common.Options;
using Newtonsoft.Json.Linq;

namespace ChartJsWrapper.Common.Handlers
{
    public delegate ICollection<LegendItem> LegendLabelsGenerator(JObject chart);
}
