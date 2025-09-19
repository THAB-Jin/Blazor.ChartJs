using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class PointStyle
    {
        public static readonly PointStyle Circle = new("circle");
        public static readonly PointStyle Cross = new("cross");
        public static readonly PointStyle CrossRot = new("crossRot");
        public static readonly PointStyle Dash = new("dash");
        public static readonly PointStyle Line = new("line");
        public static readonly PointStyle Rect = new("rect");
        public static readonly PointStyle RectRounded = new("rectRounded");
        public static readonly PointStyle RectRot = new("RectRot");
        public static readonly PointStyle Star = new("star");
        public static readonly PointStyle Triangle = new("triangle");

        public string Value { get; }
        private PointStyle(string value) { Value = value; }

        public override string ToString() => Value;
    }
}
