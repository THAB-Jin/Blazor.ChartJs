using ChartJsWrapper.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.BarChart
{
    /// <summary>
    /// The options-subconfig of a <see cref="BarConfig"/>.
    /// </summary>
    public class BarOptions : BaseConfigOptions
    {
        /// <summary>
        /// Gets or sets the scales for this chart.
        /// </summary>
        public BarScales Scales { get; set; }
    }
}
