using Newtonsoft.Json.Linq;
using ChartJsWrapper.Common.Options;

namespace ChartJsWrapper.Common.Handlers
{
    public delegate bool LegendLabelFilter(LegendItem legendItem, JObject chartData);
}
