using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    internal class Positions
    {
        public static readonly Positions Top = new("top");
        public static readonly Positions Left = new("left");
        public static readonly Positions Bottom = new("bottom");
        public static readonly Positions Right = new("right");

        public string Value { get; }
        private Positions(string value) { Value = value; }

        public override string ToString() => Value;
    }
}
