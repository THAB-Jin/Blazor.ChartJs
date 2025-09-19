using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public sealed class InteractionMode
    {

        public static readonly InteractionMode Point = new("point");

        public static readonly InteractionMode Nearest = new("nearest");

        public static readonly InteractionMode Index = new("index");

        public static readonly InteractionMode Dataset = new("dataset");

        public static readonly InteractionMode X = new("x");

        public static readonly InteractionMode Y = new("y");

        public string Value { get; }
        private InteractionMode(string value) { Value = value; }

        public override string ToString() => Value;
    }
}
