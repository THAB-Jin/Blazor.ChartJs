using ChartJsWrapper.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Options
{
    public class Hover
    {
        public InteractionMode Mode { get; set; }

        public bool? Intersect { get; set; }

        public AxisDirection Axis { get; set; }

        public long? AnimationDuration { get; set; }
    }
}
