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
        private readonly IJSRuntime _js;

        public InteropWrapper(IJSRuntime js) => _js = js;

        public async Task InitChart(string canvasId, object config) =>
            await _js.InvokeVoidAsync("./_content/ChartJsWrapper/chartInterop.initChart", canvasId, config);

        public async Task DisposeChart(string canvasId) =>
            await _js.InvokeVoidAsync("./_content/ChartJsWrapper/chartInterop.disposeChart", canvasId);
    }
}
