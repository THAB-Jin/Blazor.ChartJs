using ChartJsWrapper.Common.Options;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Handlers
{
    /// <summary>
    /// A delegate for all sorts of mouse events on a legend item.
    /// </summary>
    /// <param name="mouseEvent">The mouse event.</param>
    /// <param name="legendItem">The affected legend item.</param>
    public delegate void LegendItemMouseEvent(JObject mouseEvent, LegendItem legendItem);
}
