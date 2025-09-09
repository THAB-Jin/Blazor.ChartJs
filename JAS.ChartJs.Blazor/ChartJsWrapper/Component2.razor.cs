using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ChartJsWrapper;
using Microsoft.JSInterop;

namespace ChartJsWrapper
{
    public partial class Component2
    {
        [Inject]
        IJSRuntime jsRuntime { get; set; }


        ExampleJsInterop JsInt { get; set; }

        protected override void OnInitialized()
        {
            JsInt = new ExampleJsInterop(jsRuntime);
        }
    }
}