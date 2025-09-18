using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class Alignments
    {
        public static readonly Alignments Start = new("start");
        public static readonly Alignments Center = new("Center");
        public static readonly Alignments End = new("end");

        public string Value { get; }
        private Alignments(string value) { Value = value; }

        public override string ToString() => Value;
    }
}
