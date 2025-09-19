using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public sealed class TooltipPosition
    {
        public static readonly TooltipPosition Average = new("average");
        public static readonly TooltipPosition Nearest = new("nearest");

        public string Value { get; }
        private TooltipPosition(string value) { Value = value; }

        public override string ToString() => Value;
    }
}
