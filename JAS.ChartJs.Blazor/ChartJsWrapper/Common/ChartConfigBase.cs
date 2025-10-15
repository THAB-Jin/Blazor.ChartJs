using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common
{
    //deprecated in favor of ChartConfig
    //public abstract class ChartConfigBase
    //{
    //    protected ChartConfigBase(ChartType chartType)
    //    {
    //        Type = chartType;
    //    }
    //    public ChartType Type { get; }
    //    public string CanvasId { get; } = Guid.NewGuid().ToString();
    //}


    //public abstract class ChartConfigBase<TOptions, TData> : ChartConfigBase
    ////where constraints :
    ////TOptions must inherit from BaseConfigOptions.
    ////TData must inherit from ChartData and have a new() constructor.
    //where TOptions : BaseConfigOptions
    //where TData : ChartData, new()
    //{
    //    protected ChartConfigBase(ChartType chartType) : base(chartType)
    //    {
    //        Data = new TData();
    //    }

    //    public TOptions Options { get; set; }
    //    public TData Data { get; }
    //}

    //public abstract class ChartConfigBase<TOptions> : ChartConfigBase
    //    where TOptions : BaseConfigOptions
    //{
    //    protected ChartConfigBase(ChartType chartType) : base(chartType) { }
    //}

}
