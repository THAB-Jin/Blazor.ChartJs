using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace ChartJsWrapper
{
    public partial class PieChart
    {
        [Inject] IJSRuntime jsRuntime { get; set; }
        InteropWrapper ChartJs { get; set; }


        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            ChartJs = new InteropWrapper(jsRuntime);
            if (firstRender)
            {
                var config = new
                {
                    type = "bar",
                    data = new
                    {
                        labels = new[] { "Red", "Blue", "Yellow" },
                        datasets = new[] {
                        new {
                            label = "Votes",
                            data = new[] { 12, 19, 3 },
                            backgroundColor = new[] { "red", "blue", "yellow" }
                        }
                    }
                    }
                };

                await ChartJs.InitChart("pieChart", config);
            }
        }

        public async ValueTask DisposeAsync() =>
            await ChartJs.DisposeChart("pieChart");
    }
}