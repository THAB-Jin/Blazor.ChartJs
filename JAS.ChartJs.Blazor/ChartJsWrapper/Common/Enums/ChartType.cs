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
        //Add more chart tzpes as needed

        private ChartType(string stringValue) : base(stringValue) { }
    }
}
