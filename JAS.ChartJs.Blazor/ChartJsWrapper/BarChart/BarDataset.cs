using ChartJsWrapper.Common.Enums;
using ChartJsWrapper.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.BarChart
{
    public class BarDataset<T> : Dataset<T>
    {
        /// Creates a new instance of <see cref="BarDataset{T}"/>.
        /// <param name="horizontal">
        /// If <see langword="true"/>, the dataset-type will be set to <see cref="ChartType.HorizontalBar"/>
        /// instead of <see cref="ChartType.Bar"/>. Set this to <see langword="true"/> when using a horizontal
        /// bar chart. If this is set to <see langword="false"/> in a horizontal bar chart, the bars won't be displayed.
        /// </param>
        public BarDataset(bool horizontal = false) : base(horizontal ? ChartType.HorizontalBar : ChartType.Bar) { }

        /// Creates a new instance of <see cref="BarDataset{T}"/> with initial data.
        /// <inheritdoc cref="BarDataset(bool)"/>
        public BarDataset(IEnumerable<T> data, bool horizontal = false) : this(horizontal)
        {
            AddRange(data);
        }

        /// Creates a new instance of <see cref="BarDataset{T}"/> with
        /// a custom <see cref="ChartType"/>. Use this constructor when
        /// you implement a bar-like chart.
        /// <param name="type">The <see cref="ChartType"/> to use instead of <see cref="ChartType.Bar"/>.</param>
        protected BarDataset(ChartType type) : base(type) { }

        /// Gets or sets the fill color of the bars in the dataset.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        public IndexableOption<string> BackgroundColor { get; set; }

        /// Gets or sets the border color of the bars in the dataset.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        public IndexableOption<string> BorderColor { get; set; }

        /// Gets or sets a value to avoid drawing the bar stroke at the base of the fill.
        /// In general, this does not need to be changed except when creating chart types that derive from a bar chart.
        public IndexableOption<BorderSkipped> BorderSkipped { get; set; }

        /// Gets or sets the border width of the bars in the dataset.
        public IndexableOption<int> BorderWidth { get; set; }

        /// Gets or sets the percentage (0-1) of the available width each bar should be within the category
        /// width. 1.0 will take the whole category width and put the bars right next to each other.
        /// As per documentation <a href="https://www.chartjs.org/docs/latest/charts/bar.html#barpercentage-vs-categorypercentage">here (Chart.js)</a>.
        public double? BarPercentage { get; set; }

        /// Gets or sets the percentage (0-1) of the available width each category should be within the sample width.
        /// As per documentation <a href="https://www.chartjs.org/docs/latest/charts/bar.html#barpercentage-vs-categorypercentage">here (Chart.js).</a>.
        public double? CategoryPercentage { get; set; }

        /// Gets or sets the width of each bar in pixels.
        /// If set to <see cref="BarThickness.Flex"/>, it computes "optimal" sample widths that globally
        /// arrange bars side by side. If not set (default), bars are equally sized based on the smallest interval.
        public BarThickness BarThickness { get; set; }

        /// Gets or sets how to clip relative to the chart area. Positive values allow overflow,
        /// negative values clip that many pixels inside the chart area.
        public Clipping? Clip { get; set; }

        /// Gets or sets the fill color of the bars when hovered.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        public IndexableOption<string> HoverBackgroundColor { get; set; }

        /// Gets or sets the stroke color of the bars when hovered.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        public IndexableOption<string> HoverBorderColor { get; set; }

        /// Gets or sets the stroke width of the bars when hovered.
        public IndexableOption<int> HoverBorderWidth { get; set; }

        /// Gets or sets the label for the dataset which appears in the legend and tooltips.
        public string Label { get; set; }

        /// Gets or sets the maximum thickness of the bars in pixels.
        public double? MaxBarThickness { get; set; }

        /// Gets or sets the minimum length of the bars in pixels.
        public double? MinBarLength { get; set; }

        /// Gets or sets the id of the group to which this dataset belongs to
        /// (when stacked, each group will be a separate stack).
        /// <para>
        /// In order to use this, the 'Stacked' property of the corresponding
        /// axis has to be set to <see langword="true"/>. The 'Stacked' property
        /// is only available in axes from the <see cref="Axes"/> namespace.
        /// </para>
        public string Stack { get; set; }

        /// Gets or sets the drawing order of this dataset.
        /// Also affects the order for stacking, tooltips, and the legend.
        public int? Order { get; set; }

        /// Gets or sets the ID of the x axis to plot this dataset on. If not specified,
        /// this defaults to the ID of the first found x axis.
        [JsonProperty("xAxisID")]
        public string XAxisId { get; set; }

        /// Gets or sets the ID of the y axis to plot this dataset on. If not specified,
        /// this defaults to the ID of the first found y axis.
        [JsonProperty("yAxisID")]
        public string YAxisId { get; set; }
    }
}
