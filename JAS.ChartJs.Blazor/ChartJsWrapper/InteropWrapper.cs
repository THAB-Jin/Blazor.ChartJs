using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper
{
    internal class InteropWrapper
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public InteropWrapper(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/ChartJsWrapper/chartInterop.js").AsTask());
        }

        public async ValueTask InitChart(string canvasId, object config)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("initChart", canvasId, config);

        }


        public async ValueTask DisposeChart(string canvasId)
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("disposeChart", canvasId);
        }
    }
}
