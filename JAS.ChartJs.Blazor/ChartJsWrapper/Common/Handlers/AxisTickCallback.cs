using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartJsWrapper.Common.Handlers
{
    // A delegate used for customizing tick marks on an axis.
    public delegate string AxisTickCallback(JValue value, int index, JArray values);
}
