using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public sealed class AxisType : StringEnum
    {
        public static AxisType Linear => new AxisType("linear");
      
        public static AxisType Logarithmic => new AxisType("logarithmic");

        public static AxisType Category => new AxisType("category");

        public static AxisType Time => new AxisType("time");


        private AxisType(string stringRep) : base(stringRep) { }
    }
}
