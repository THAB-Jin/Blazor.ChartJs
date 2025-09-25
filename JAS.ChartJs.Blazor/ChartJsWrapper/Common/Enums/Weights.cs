using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class Weights
    {
        public static readonly Weights Normal = new("normal");
        public static readonly Weights Bold = new("bold");
        public static readonly Weights Lighter = new("lighter");
        public static readonly Weights Bolder = new("bolder");
        public static readonly int Number;

        public string Value { get; }
        private Weights(string value) { Value = value; }

        public override string ToString() => Value;
    }
}
