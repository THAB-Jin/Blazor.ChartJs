using Microsoft.JSInterop;

namespace BlazorChartJsWrapper.Demo.JsFiles
{
    public static class JsExtension
    {
        public static async ValueTask AlertifyAlert(this IJSRuntime JsRun, string message)
        {
            await JsRun.InvokeVoidAsync("alertify.confirm", message);
        }
    }
}
