using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public sealed class AxisDirection : StringEnum
    {
        public static AxisDirection X => new AxisDirection("x");

        public static AxisDirection Y => new AxisDirection("y");

        public static AxisDirection XY => new AxisDirection("xy");

        private AxisDirection(string stringRep) : base(stringRep) { }
    }
}
