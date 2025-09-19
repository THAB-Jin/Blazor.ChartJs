using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public sealed class BorderCapStyle : StringEnum
    {
        public static BorderCapStyle Butt => new BorderCapStyle("butt");
        public static BorderCapStyle Round => new BorderCapStyle("round");

        public static BorderCapStyle Square => new BorderCapStyle("square");

        private BorderCapStyle(string stringValue) : base(stringValue) { }

    }
}
