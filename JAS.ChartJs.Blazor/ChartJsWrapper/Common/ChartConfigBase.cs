using ChartJsWrapper.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    public abstract class ChartConfigBase
    {
        protected ChartConfigBase(ChartType chartType)
        {
            Type = chartType;
        }
        public ChartType Type { get; }
        public string CanvasId { get; } = Guid.NewGuid().ToString();
    }


    public abstract class ChartConfigBase<TOptions, TData> : ChartConfigBase
    where TOptions : BaseConfigOptions
    where TData : ChartData, new()
    {
        protected ChartConfigBase(ChartType chartType) : base(chartType)
        {
            Data = new TData();
        }

        public TOptions Options { get; set; }
        public TData Data { get; }
    }

}
