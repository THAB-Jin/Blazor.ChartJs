using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Enums
{
    public class BorderSkipped : ObjectEnum
    {
        /// <summary>
        ///     Creates a new instance of the <see cref="BorderSkipped" /> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string" /> value to set.</param>
        private BorderSkipped(string stringValue) : base(stringValue) { }

        /// <summary>
        ///     Creates a new instance of the <see cref="BorderSkipped" /> class.
        /// </summary>
        /// <param name="boolValue">The <see cref="bool" /> value to set.</param>
        private BorderSkipped(bool boolValue) : base(boolValue) { }

        /// <summary>
        ///     The bottom border skipped style.
        /// </summary>
        public static BorderSkipped Bottom => new BorderSkipped("bottom");

        /// <summary>
        ///     The false border skipped style.
        /// </summary>
        public static BorderSkipped False => new BorderSkipped(false);

        /// <summary>
        ///     The left border skipped style.
        /// </summary>
        public static BorderSkipped Left => new BorderSkipped("left");

        /// <summary>
        ///     The right border skipped style.
        /// </summary>
        public static BorderSkipped Right => new BorderSkipped("right");

        /// <summary>
        ///     The top border skipped style.
        /// </summary>
        public static BorderSkipped Top => new BorderSkipped("top");
    }
}
