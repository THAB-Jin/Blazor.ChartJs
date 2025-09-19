using ChartJsWrapper.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Axes
{
    public sealed class AxisDisplay : ObjectEnum
    {
        public static AxisDisplay False => new AxisDisplay(false);

        public static AxisDisplay True => new AxisDisplay(true);

        // Visible only if at least one associated dataset is visible
        public static AxisDisplay Auto => new AxisDisplay("auto");


        private AxisDisplay(string stringValue) : base(stringValue) { }
        private AxisDisplay(bool boolValue) : base(boolValue) { }
    }
}
