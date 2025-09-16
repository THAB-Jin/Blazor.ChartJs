using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class ChartType
    {
        public static readonly ChartType Bar = new("bar");
        public static readonly ChartType Pie = new("pie");

        public string Value { get; }
        private ChartType(string value) { Value = value; }

        public override string ToString() => Value;
    }


    //there are ways to improve this class
    //we could make it so that the enums are comparable etc...
    //if this ever becomes necessary see mariusmuntean's github -> StringEnum.cs
}
