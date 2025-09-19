using ChartJsWrapper.Common.Handlers;
using ChartJsWrapper.Common.Interop;
using ChartJsWrapper.Common.Enums;

namespace ChartJsWrapper.Common.Options
{
    public class BaseConfigOptions
    {
        // Gets or sets the title of this chart.
        public Title Title { get; set; }

        // Gets or sets a value indicating whether the chart canvas should be resized when its container is.
        // See important note: <a href="https://www.chartjs.org/docs/latest/general/responsive.html#important-note">here (Chart.js)</a>.
        public bool? Responsive { get; set; }

        // Gets or sets the canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas).
        // <para>Note that this option is ignored if the height is explicitly defined either as attribute (of the canvas) or via the style.</para>
        public double? AspectRatio { get; set; }

        // Gets or sets a value indicating whether to maintain the original canvas aspect ratio (width / height) when resizing.
        public bool? MaintainAspectRatio { get; set; }

        // Gets or sets the duration in milliseconds it takes to animate to new size after a resize event.
        public int? ResponsiveAnimationDuration { get; set; }

        // Gets or sets the legend for this chart.
        public Legend Legend { get; set; }

        // Gets or sets the tooltip options for this chart.
        public Tooltip Tooltips { get; set; }

        // Gets or sets the animation-configuration for this chart.
        public Animation Animation { get; set; }

        // Gets or sets the layout options for this chart.
        // Link: https://www.chartjs.org/docs/latest/configuration/layout.html
        public Layout Layout { get; set; }

        // Gets the plugin options. The key has to be the unique identification of the plugin.
        // Reference for Chart.js plugin options:
        // <a href="https://www.chartjs.org/docs/latest/developers/plugins.html#plugin-options"/>
        public Dictionary<string, object> Plugins { get; } = new Dictionary<string, object>();

        // Gets or sets the browser events that the chart should listen to for tooltips and hovering.
        // If <see langword="null"/>, this includes <see cref="BrowserEvent.MouseMove"/>, <see cref="BrowserEvent.MouseOut"/>,
        // <see cref="BrowserEvent.Click"/>, <see cref="BrowserEvent.TouchStart"/> and <see cref="BrowserEvent.TouchMove"/> (by default).
        public BrowserEvent[] Events { get; set; }

        // Gets or sets the callback to call when an event of type <see cref="BrowserEvent.MouseUp"/> or
        // <see cref="BrowserEvent.Click"/> fires on the chart.
        // Called in the context of the chart and passed the event and an array of active elements.
        // See <see cref="JavaScriptHandler{T}"/> and <see cref="DelegateHandler{T}"/>.
        public IMethodHandler<ChartMouseEvent> OnClick { get; set; }

        // Gets or sets the callback to call when any of the <see cref="Events"/> fire on the chart.
        // Called in the context of the chart and passed the event and an array of
        // active elements (bars, points, etc).
        // See <see cref="JavaScriptHandler{T}"/> and <see cref="DelegateHandler{T}"/>.
        public IMethodHandler<ChartMouseEvent> OnHover { get; set; }

        // Gets or sets the hover configuration for this chart.
        public Hover Hover { get; set; }

    }
}
