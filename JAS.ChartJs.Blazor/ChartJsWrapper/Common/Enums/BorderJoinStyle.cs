using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class BorderJoinStyle : StringEnum
    {
        public static BorderJoinStyle Bevel => new BorderJoinStyle("bevel");

        public static BorderJoinStyle Round => new BorderJoinStyle("round");

        public static BorderJoinStyle Miter => new BorderJoinStyle("miter");

        private BorderJoinStyle(string stringValue) : base(stringValue) { }
    }
}
