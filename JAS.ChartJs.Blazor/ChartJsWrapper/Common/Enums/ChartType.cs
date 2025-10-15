using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class ChartType : StringEnum
    {
        /// <summary>
        /// The bar chart type.
        /// </summary>
        public static ChartType Bar => new ChartType("bar");
        public static ChartType Pie => new ChartType("pie");
        public static ChartType HorizontalBar => new ChartType("horizontalBar");
        public static ChartType Doughnut => new ChartType("doughnut");
        //Add more chart types as needed
        public static ChartType Line => new ChartType("line");
        public static ChartType Radar => new ChartType("radar");
        public static ChartType Bubble => new ChartType("bubble");
        public static ChartType PolarArea => new ChartType("polarArea");
        public static ChartType Scatter => new ChartType("scatter");
        public static ChartType Custom(string customChartType) => new ChartType(customChartType);

        private ChartType(string stringValue) : base(stringValue) { }
    }
}
